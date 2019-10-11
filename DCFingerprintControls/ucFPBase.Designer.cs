namespace DCFingerprintControls
{
    partial class ucFPBase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstFPstatus = new System.Windows.Forms.ListBox();
            this.picFP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(600, 28);
            this.lblWelcome.TabIndex = 39;
            this.lblWelcome.Text = "Enrol Fingerprint for ...";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatus.Location = new System.Drawing.Point(158, 142);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(429, 41);
            this.lblStatus.TabIndex = 38;
            // 
            // lstFPstatus
            // 
            this.lstFPstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFPstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstFPstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFPstatus.FormattingEnabled = true;
            this.lstFPstatus.Location = new System.Drawing.Point(158, 38);
            this.lstFPstatus.Margin = new System.Windows.Forms.Padding(4);
            this.lstFPstatus.Name = "lstFPstatus";
            this.lstFPstatus.Size = new System.Drawing.Size(429, 91);
            this.lstFPstatus.TabIndex = 37;
            // 
            // picFP
            // 
            this.picFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picFP.Location = new System.Drawing.Point(9, 36);
            this.picFP.Name = "picFP";
            this.picFP.Size = new System.Drawing.Size(138, 149);
            this.picFP.TabIndex = 36;
            this.picFP.TabStop = false;
            // 
            // ucFPBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstFPstatus);
            this.Controls.Add(this.picFP);
            this.Name = "ucFPBase";
            this.Size = new System.Drawing.Size(600, 190);
            this.Load += new System.EventHandler(this.ucFPBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblWelcome;
        protected System.Windows.Forms.Label lblStatus;
        protected System.Windows.Forms.ListBox lstFPstatus;
        protected System.Windows.Forms.PictureBox picFP;
    }
}
