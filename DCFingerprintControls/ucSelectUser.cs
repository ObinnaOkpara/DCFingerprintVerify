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
using DCFingerprintControls.Classes;
using System.Net.Http;
using Newtonsoft.Json;
using DCFingerprintClasses;

namespace DCFingerprintControls
{
    public partial class ucSelectUser : UserControl
    {
        public Stafftab SelectedStaff { get; private set; }

        public event EventHandler UserSelected;

        private List<Stafftab> Staffs;

        public ucSelectUser()
        {
            InitializeComponent();
            lblTitle.Text = $"Find Staff to Enrol.";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateFormControls.CheckTextboxes(this, errorProvider1))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;

            using (var HC = new HttpClient())
            {
                var response = await HC.GetAsync(Constants.baseUrl + $"Staff/{txtStaffId.Text}");
                if (response.IsSuccessStatusCode)
                {
                    var rtn = JsonConvert.DeserializeObject<ApiReturnObject<List<Stafftab>>>(await response.Content.ReadAsStringAsync());

                    Staffs = rtn.Object;

                    dgridUsers.DataSource = Staffs;
                    dgridUsers.Refresh();

                    if (!rtn.Status)
                    {
                        MessageBox.Show(rtn.Message);
                    }
                }
            }


            Cursor = Cursors.Default;
        }

        private void dgridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                SelectedStaff = Staffs[e.RowIndex];

                this.UserSelected?.Invoke(this, e);
            }
        }
    }
}
