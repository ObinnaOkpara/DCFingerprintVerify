namespace DCFingerprintEnrol
{
    partial class frmVerify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpS = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucVerifyFingerprint1 = new DCFingerprintControls.ucVerifyFingerprint();
            this.grpFP = new System.Windows.Forms.GroupBox();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grpS
            // 
            this.grpS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpS.Location = new System.Drawing.Point(0, 225);
            this.grpS.Margin = new System.Windows.Forms.Padding(2);
            this.grpS.Name = "grpS";
            this.grpS.Padding = new System.Windows.Forms.Padding(2);
            this.grpS.Size = new System.Drawing.Size(779, 239);
            this.grpS.TabIndex = 8;
            this.grpS.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 469);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 37);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ucVerifyFingerprint1
            // 
            this.ucVerifyFingerprint1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVerifyFingerprint1.Enabled = false;
            this.ucVerifyFingerprint1.Location = new System.Drawing.Point(0, 3);
            this.ucVerifyFingerprint1.Name = "ucVerifyFingerprint1";
            this.ucVerifyFingerprint1.Size = new System.Drawing.Size(779, 190);
            this.ucVerifyFingerprint1.TabIndex = 10;
            // 
            // grpFP
            // 
            this.grpFP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFP.Location = new System.Drawing.Point(0, 225);
            this.grpFP.Margin = new System.Windows.Forms.Padding(2);
            this.grpFP.Name = "grpFP";
            this.grpFP.Padding = new System.Windows.Forms.Padding(2);
            this.grpFP.Size = new System.Drawing.Size(779, 239);
            this.grpFP.TabIndex = 8;
            this.grpFP.TabStop = false;
            // 
            // grpStaff
            // 
            this.grpStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStaff.Location = new System.Drawing.Point(0, 225);
            this.grpStaff.Margin = new System.Windows.Forms.Padding(2);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Padding = new System.Windows.Forms.Padding(2);
            this.grpStaff.Size = new System.Drawing.Size(779, 239);
            this.grpStaff.TabIndex = 8;
            this.grpStaff.TabStop = false;
            // 
            // frmVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 513);
            this.Controls.Add(this.ucVerifyFingerprint1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpS);
            this.Name = "frmVerify";
            this.Text = "frmVerify";
            this.Load += new System.EventHandler(this.frmVerify_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFP;
        private System.Windows.Forms.Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DCFingerprintControls.ucVerifyFingerprint ucVerifyFingerprint1;
        private System.Windows.Forms.GroupBox grpS;
        private System.Windows.Forms.GroupBox grpStaff;
    }
}