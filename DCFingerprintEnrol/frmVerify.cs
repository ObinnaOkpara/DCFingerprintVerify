using DCFingerprintClasses.Models;
using DCFingerprintControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCFingerprintEnrol
{
    public partial class frmVerify : Form
    {
        public Useracct LoggedInUser { get; set; }

        private Form home;

        public frmVerify(Useracct _LoggedInUser, Form _home)
        {
            home = _home;
            LoggedInUser = _LoggedInUser;
            InitializeComponent();
        }

        private void ucSelectUser1_UserSelected(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            var ctrl = (ucSelectUser)sender;
            var Staff = ctrl.SelectedStaff;

            if (Staff.Fingerprints != null && Staff.Fingerprints.Count>0)
            {
                var ucVerifyFPCtrl = new ucVerifyFingerprint(Staff);

                ucVerifyFPCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
                ucVerifyFPCtrl.Location = new System.Drawing.Point(3, 18);
                ucVerifyFPCtrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                ucVerifyFPCtrl.Name = "ucVerifyFPCtrl";
                ucVerifyFPCtrl.Size = new System.Drawing.Size(1062, 248);
                ucVerifyFPCtrl.TabIndex = 0;

                grpFP.Controls.Add(ucVerifyFPCtrl);
            }
            else
            {
                MessageBox.Show("No Registered Fingerprint for this User.", "No Fingerprint");
            }

            Cursor = Cursors.Default;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
