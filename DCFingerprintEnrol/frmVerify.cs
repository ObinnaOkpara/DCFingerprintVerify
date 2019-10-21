using DCFingerprintClasses;
using DCFingerprintClasses.Models;
using DCFingerprintControls;
using DCFingerprintControls.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCFingerprintEnrol
{
    public partial class frmVerify : Form
    {
        public Useracct LoggedInUser { get; set; }
        private List<Fingerprint> FPS = new List<Fingerprint>();
        private Form home;
        ucUserDetails ucUserdetail;
        private ApiReturnObject<List<Fingerprint>> rtn;

        public frmVerify(Useracct _LoggedInUser, Form _home)
        {
            home = _home;
            LoggedInUser = _LoggedInUser;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private async void frmVerify_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ucVerifyFingerprint1.StaffVerified += UcVerifyFingerprint1_StaffVerified;

            using (var HC = new HttpClient())
            {
                var response = await HC.GetAsync(Constants.baseUrl + $"Staff/Fingerprints");
                if (response.IsSuccessStatusCode)
                {
                    rtn = JsonConvert.DeserializeObject<ApiReturnObject<List<Fingerprint>>>(await response.Content.ReadAsStringAsync());

                    FPS = rtn.Object;
                }

                if (FPS.Count <= 0)
                {
                    MessageBox.Show("An error occured while fetching fingerprints. Please try again later.");
                    this.Close();
                }
                else
                {
                    ucVerifyFingerprint1.Enabled = true;
                    ucVerifyFingerprint1.StartVerify(FPS);
                }
            }

            Cursor = Cursors.Default;
        }

        private void UcVerifyFingerprint1_StaffVerified(object sender, EventArgs e)
        {
            grpS.Controls.Clear();

            var ctrl = (ucVerifyFingerprint)sender;

            // Add UserDetail control
            ucUserdetail = new ucUserDetails(ctrl.Staff);

            ucUserdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            ucUserdetail.Location = new System.Drawing.Point(3, 18);
            ucUserdetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ucUserdetail.Name = "ucEnrolFP1";
            ucUserdetail.Size = new System.Drawing.Size(1062, 248);
            ucUserdetail.TabIndex = 0;

            grpS.Controls.Add(ucUserdetail);

        }
    }
}
