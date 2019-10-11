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
    public partial class frmEnrol : Form
    {
        public Useracct LoggedInUser { get; set; }

        private Form home;
        private ucEnrolFingerprint ucEnrolFPCtrl;

        public frmEnrol(Useracct _LoggedInUser,Form _home)
        {
            home = _home;
            LoggedInUser = _LoggedInUser;
            InitializeComponent();
        }

        private void frmEnrol_Load(object sender, EventArgs e)
        {
        }

        private void ucSelectUser1_UserSelected(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            var ctrl = (ucSelectUser)sender;

            // Add enrolFingerprint control
            ucEnrolFPCtrl = new ucEnrolFingerprint(ctrl.SelectedStaff);

            ucEnrolFPCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            ucEnrolFPCtrl.Location = new System.Drawing.Point(3, 18);
            ucEnrolFPCtrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ucEnrolFPCtrl.Name = "ucEnrolFP1";
            ucEnrolFPCtrl.Size = new System.Drawing.Size(1062, 248);
            ucEnrolFPCtrl.TabIndex = 0;

            grpFP.Controls.Add(ucEnrolFPCtrl);

            // Add UserDetail control
            var ucUserdetail = new ucUserDetails(ctrl.SelectedStaff);

            ucUserdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            ucUserdetail.Location = new System.Drawing.Point(3, 18);
            ucUserdetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ucUserdetail.Name = "ucEnrolFP1";
            ucUserdetail.Size = new System.Drawing.Size(1062, 248);
            ucUserdetail.TabIndex = 0;
            ucUserdetail.CtrlClosed += UcUserdetail_CtrlClosed;

            grpUser.Controls.Add(ucUserdetail);

            ucUserdetail.BringToFront();

            Cursor = Cursors.Default;
        }

        private void UcUserdetail_CtrlClosed(object sender, EventArgs e)
        {
            ucEnrolFPCtrl.Stop();
            ucEnrolFPCtrl.Dispose();
            grpFP.Controls.Remove(ucEnrolFPCtrl);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

    }
}
