using DCFingerprintClasses.Models;
using DPFP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCFingerprintControls
{
    public class ucVerifyFingerprint: ucFPBase
    {
        private List<Template> StaffTemplates = new List<Template>();
        private DPFP.Verification.Verification Verificator;

        private Stafftab Staff;

        public ucVerifyFingerprint(Stafftab _staff)
        {
            Staff = _staff;
            this.Load += UcVerifyFingerprint_Load;
            this.ControlRemoved += UcVerifyFingerprint_ControlRemoved;
        }

        private void UcVerifyFingerprint_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (Capturer != null)
            {
                Stop();
            }
        }

        private void UcVerifyFingerprint_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Enrol Fingerprint for {Staff.Surname + " " + Staff.Othernames}";
            lstFPstatus.Items.Clear();
            Init();
            Start();

            Verificator = new DPFP.Verification.Verification();

            foreach (var fp in Staff.Fingerprints)
            {
                using (var stream = new MemoryStream(fp.FPfile))
                {
                    StaffTemplates.Add(new Template(stream));
                }
            }
        }

        protected void disableMe()
        {
            try
            {
                this.Invoke(new Function(delegate ()
                {
                    Enabled = false;
                }));
            }
            catch (Exception)
            {
            }
        }

        protected override void Process(DPFP.Sample Sample)
        {
            try
            {
                // Draw fingerprint sample image.
                DrawPicture(ConvertSampleToBitmap(Sample));

                // Process the sample and create a feature set for the enrollment purpose.
                DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

                // Check quality of the sample and start verification if it's good
                // TODO: move to a separate task
                if (features != null)
                {
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    bool found = false;
                    int index = 0;
                    // Compare the feature set with each of our template
                    foreach (var template in StaffTemplates)
                    {
                        Verificator.Verify(features, template, ref result);

                        if (result.Verified)
                        {
                            found = true;

                            MakeReport("VERIFIED SUCCESSFULLY.");
                            Stop();
                            disableMe();
                            break;
                        }
                        index++;
                    }
                    if (!found)
                    {
                        MakeReport("VERIFY FAILED.");
                        Start();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while comparing with fingerprint database. \n\r\n\r" + ex.ToString());
            }
        }

    }
}
