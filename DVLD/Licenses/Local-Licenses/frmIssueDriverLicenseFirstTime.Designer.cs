namespace DVLD.Licenses.Local_Licenses
{
    partial class frmIssueDriverLicenseFirstTime
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
            ctrlDrivingLicenseApplicationInfo1 = new DVLD.Applications.ctrlDrivingLicenseApplicationInfo();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtNotes = new TextBox();
            btnIssueLicense = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(13, 14);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(790, 401);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 423);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 1;
            label1.Text = "Notes:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(98, 423);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(152, 423);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(626, 97);
            txtNotes.TabIndex = 51;
            // 
            // btnIssueLicense
            // 
            btnIssueLicense.BackColor = Color.Indigo;
            btnIssueLicense.FlatStyle = FlatStyle.Flat;
            btnIssueLicense.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIssueLicense.ForeColor = Color.White;
            btnIssueLicense.ImageAlign = ContentAlignment.MiddleRight;
            btnIssueLicense.Location = new Point(616, 546);
            btnIssueLicense.Name = "btnIssueLicense";
            btnIssueLicense.Size = new Size(162, 40);
            btnIssueLicense.TabIndex = 53;
            btnIssueLicense.Text = "Issue";
            btnIssueLicense.UseVisualStyleBackColor = false;
            btnIssueLicense.Click += btnIssueLicense_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(448, 546);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 52;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 610);
            Controls.Add(btnIssueLicense);
            Controls.Add(btnClose);
            Controls.Add(txtNotes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Name = "frmIssueDriverLicenseFirstTime";
            Text = "frmIssueDriverLicenseFirstTime";
            Load += frmIssueDriverLicenseFirstTime_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtNotes;
        private Button btnIssueLicense;
        private Button btnClose;
    }
}