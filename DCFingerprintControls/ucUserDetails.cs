using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCFingerprintClasses.Models;

namespace DCFingerprintControls
{
    public partial class ucUserDetails : UserControl
    {
        public Stafftab Staff { get; private set; }
        public event EventHandler CtrlClosed;


        public ucUserDetails(Stafftab _Staff)
        {
            Staff = _Staff;

            InitializeComponent();
        }

        private void ucUserDetails_Load(object sender, EventArgs e)
        {
            lblStaffDepartment.Text = Staff.Deptcode;
            lblStaffOthername.Text = Staff.Othernames.Trim();
            lblStaffStaffSex.Text = Staff.Sex == 1 ? "Male" : "Female";
            lblStaffSurname.Text = Staff.Surname.Trim();
            lblStaffTitle.Text = Staff.Title;

        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.DarkRed;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.CtrlClosed?.Invoke(this, e);

            this.Parent.Controls.Remove(this);
        }
    }
}
