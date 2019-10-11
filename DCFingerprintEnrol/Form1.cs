using DCFingerprintClasses;
using DCFingerprintClasses.Models;
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
    public partial class Form1 : Form
    {
        public Useracct LoggedInUser { get; set; }

        public Form1(Useracct _LoggedInUser)
        {
            LoggedInUser = _LoggedInUser;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                groupBox1.Hide();
                groupBox2.Show();
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateFormControls.CheckTextboxes(groupBox1, errorProvider1))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;

            using (var HC = new HttpClient())
            {
                var response = await HC.GetAsync(Constants.baseUrl + $"Staff/{txtStaffId.Text}/{txtPassword.Text}");
                if (response.IsSuccessStatusCode)
                {
                    var rtn = JsonConvert.DeserializeObject<ApiReturnObject<Useracct>>(await response.Content.ReadAsStringAsync());
                    MessageBox.Show(rtn.Message);

                    if (rtn.Status)
                    {
                        LoggedInUser = rtn.Object;
                        groupBox1.Hide();
                        groupBox2.Show();
                    }
                }
            }


            Cursor = Cursors.Default;
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            var frm = new frmEnrol(LoggedInUser, this);

            frm.Show();
            this.Hide();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var frm = new frmVerify(LoggedInUser, this);

            frm.Show();
            this.Hide();
        }
    }
}
