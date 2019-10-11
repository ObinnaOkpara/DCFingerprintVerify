using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCFingerprintControls
{
    delegate void Function();   // a simple delegate for marshalling calls from event handlers to the GUI thread

    public partial class ucFPBase : UserControl, DPFP.Capture.EventHandler
    {
        protected DPFP.Capture.Capture Capturer = new DPFP.Capture.Capture();

        public ucFPBase()
        {
            InitializeComponent();
        }

        private void ucFPBase_Load(object sender, EventArgs e)
        {

        }


        protected void Init()
        {
            Capturer = new DPFP.Capture.Capture();                  // Create a capture operation.
            Capturer.EventHandler = this;                           // Subscribe for capturing events.
        }

        protected void Start()
        {
            Capturer.StartCapture();
            SetPrompt("Using the fingerprint reader, scan your fingerprint.");
        }

        public void Stop()
        {
            Capturer.StopCapture();
        }



        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }
        #endregion


        #region FingerPrint Processes

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected virtual void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate ()
            {
                lblStatus.Text = prompt;
            }));
        }
        protected virtual void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                lstFPstatus.Items.Add(message);
                lstFPstatus.TopIndex = lstFPstatus.Items.Count - 1;
            }));
        }

        protected virtual void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                picFP.Image = new Bitmap(bitmap, picFP.Size);   // fit the image into the picture box
            }));
        }

        protected virtual void UpdateStatus(DPFP.Processing.Enrollment Enroller)
        {
            // Show number of samples needed.
            SetPrompt(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }

        protected virtual void Process(DPFP.Sample sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(sample));
        }

        #endregion

    }
}
