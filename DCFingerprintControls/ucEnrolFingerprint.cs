using DCFingerprintClasses;
using DCFingerprintClasses.Models;
using DCFingerprintControls.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCFingerprintControls
{
    public class ucEnrolFingerprint : ucFPBase
    {
        private DPFP.Template StaffTemplate;
        private DPFP.Processing.Enrollment Enroller;
        private Stafftab Staff;

        public ucEnrolFingerprint(Stafftab _staff)
        {
            Staff = _staff;
            this.Load += UcEnrolFingerprint_Load;
            this.ControlRemoved += UcEnrolFingerprint_ControlRemoved;
        }

        private void UcEnrolFingerprint_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (Capturer != null)
            {
                Stop();
            }
        }

        private void UcEnrolFingerprint_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Enrol Fingerprint for {Staff.Surname.Trim() + " " + Staff.Othernames.Trim()}";
            Enroller = new DPFP.Processing.Enrollment();            // Create an enrollment.
            lstFPstatus.Items.Clear();
            UpdateStatus(Enroller);
            Init();
            Start();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null)
            {
                try
                {
                    MakeReport("The fingerprint feature set was created.");
                    Enroller.AddFeatures(features);     // Add feature set to template.
                }
                finally
                {
                    UpdateStatus(Enroller);

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
                            OnTemplate(Enroller.Template);

                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus(Enroller);
                            OnTemplate(null);
                            Start();
                            break;
                    }
                }
            }
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(async delegate ()
            {
                if (template != null)
                {
                    StaffTemplate = template;

                    SetPrompt("The fingerprint template has been captured successfully. \n\n Please wait while the template is being proccessed.");

                    Cursor = Cursors.WaitCursor;


                    using (var HC = new HttpClient())
                    {

                        var file = new byte[] { };
                        StaffTemplate.Serialize(ref file);

                        var fp = new Fingerprint()
                        {
                            DateAdded = DateTime.Now,
                            StafftabId = Staff.Id,
                            FPfile = file
                        };

                        var hc = new StringContent(JsonConvert.SerializeObject(fp), Encoding.UTF8, "application/json");

                        var response = await HC.PostAsync(Constants.baseUrl + "Staff/Fingerprint", hc);
                        if (response.IsSuccessStatusCode)
                        {
                            var rtnString = await response.Content.ReadAsStringAsync();
                            var rtn = JsonConvert.DeserializeObject<ApiReturnObject<Fingerprint>>(rtnString);
                            MessageBox.Show(rtn.Message);

                            if (rtn.Status)
                            {
                                this.Enabled = false;
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("An error occured. Please Try again.");
                            Start();
                        }
                    }

                    Cursor = Cursors.Default;
                }
                else MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

    }
}
