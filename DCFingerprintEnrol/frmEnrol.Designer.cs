namespace DCFingerprintEnrol
{
    partial class frmEnrol
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grpFP = new System.Windows.Forms.GroupBox();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.ucSelectUser1 = new DCFingerprintControls.ucSelectUser();
            this.grpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 471);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpFP
            // 
            this.grpFP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFP.Location = new System.Drawing.Point(0, 249);
            this.grpFP.Margin = new System.Windows.Forms.Padding(2);
            this.grpFP.Name = "grpFP";
            this.grpFP.Padding = new System.Windows.Forms.Padding(2);
            this.grpFP.Size = new System.Drawing.Size(801, 219);
            this.grpFP.TabIndex = 7;
            this.grpFP.TabStop = false;
            // 
            // grpUser
            // 
            this.grpUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUser.Controls.Add(this.ucSelectUser1);
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Margin = new System.Windows.Forms.Padding(2);
            this.grpUser.Name = "grpUser";
            this.grpUser.Padding = new System.Windows.Forms.Padding(2);
            this.grpUser.Size = new System.Drawing.Size(801, 245);
            this.grpUser.TabIndex = 8;
            this.grpUser.TabStop = false;
            // 
            // ucSelectUser1
            // 
            this.ucSelectUser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectUser1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSelectUser1.Location = new System.Drawing.Point(0, 11);
            this.ucSelectUser1.Name = "ucSelectUser1";
            this.ucSelectUser1.Size = new System.Drawing.Size(801, 229);
            this.ucSelectUser1.TabIndex = 0;
            this.ucSelectUser1.UserSelected += new System.EventHandler(this.ucSelectUser1_UserSelected);
            // 
            // frmEnrol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.grpFP);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnrol";
            this.Text = "frmEnrol";
            this.Load += new System.EventHandler(this.frmEnrol_Load);
            this.grpUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DCFingerprintControls.ucSelectUser ucSelectUser1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpFP;
        private System.Windows.Forms.GroupBox grpUser;
    }
}