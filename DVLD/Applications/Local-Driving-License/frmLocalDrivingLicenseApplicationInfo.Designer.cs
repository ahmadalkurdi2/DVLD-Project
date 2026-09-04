namespace DVLD.Applications.Local_Driving_License
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            ctrlDrivingLicenseApplicationInfo1 = new ctrlDrivingLicenseApplicationInfo();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(13, 5);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(792, 407);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(619, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(164, 40);
            btnClose.TabIndex = 49;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 478);
            Controls.Add(btnClose);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Name = "frmLocalDrivingLicenseApplicationInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLocalDrivingLicenseApplicationInfo";
            Load += frmLocalDrivingLicenseApplicationInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Button btnClose;
    }
}