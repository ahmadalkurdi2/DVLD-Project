namespace DVLD.Applications.International_Driving_License
{
    partial class frmNewInternationalLicenseApplication
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
            ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            groupBox1 = new GroupBox();
            lblCreatedByUser = new Label();
            lblExpirationDate = new Label();
            lblInternationalLicenseID = new Label();
            lblLocalLicenseID = new Label();
            lblFees = new Label();
            lblIssueDate = new Label();
            lblApplicationDate = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            lblApplicationID = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            btnIssueLicense = new Button();
            llShowLicenseInfo = new LinkLabel();
            llShowLicenseHistory = new LinkLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 25);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(810, 564);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverInfoWithFilter1_OnLicenseSelected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCreatedByUser);
            groupBox1.Controls.Add(lblExpirationDate);
            groupBox1.Controls.Add(lblInternationalLicenseID);
            groupBox1.Controls.Add(lblLocalLicenseID);
            groupBox1.Controls.Add(lblFees);
            groupBox1.Controls.Add(lblIssueDate);
            groupBox1.Controls.Add(lblApplicationDate);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(lblApplicationID);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(45, 586);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(968, 141);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info";
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Location = new Point(821, 103);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(49, 23);
            lblCreatedByUser.TabIndex = 51;
            lblCreatedByUser.Text = "[???]";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Location = new Point(821, 35);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(112, 23);
            lblExpirationDate.TabIndex = 50;
            lblExpirationDate.Text = "[??/??/????]";
            // 
            // lblInternationalLicenseID
            // 
            lblInternationalLicenseID.AutoSize = true;
            lblInternationalLicenseID.Location = new Point(539, 69);
            lblInternationalLicenseID.Name = "lblInternationalLicenseID";
            lblInternationalLicenseID.Size = new Size(49, 23);
            lblInternationalLicenseID.TabIndex = 49;
            lblInternationalLicenseID.Text = "[???]";
            // 
            // lblLocalLicenseID
            // 
            lblLocalLicenseID.AutoSize = true;
            lblLocalLicenseID.Location = new Point(539, 107);
            lblLocalLicenseID.Name = "lblLocalLicenseID";
            lblLocalLicenseID.Size = new Size(49, 23);
            lblLocalLicenseID.TabIndex = 48;
            lblLocalLicenseID.Text = "[???]";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(539, 29);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(49, 23);
            lblFees.TabIndex = 47;
            lblFees.Text = "[???]";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(213, 107);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(112, 23);
            lblIssueDate.TabIndex = 46;
            lblIssueDate.Text = "[??/??/????]";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Location = new Point(213, 73);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(112, 23);
            lblApplicationDate.TabIndex = 45;
            lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.User_32__2;
            pictureBox8.Location = new Point(783, 98);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 32);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 44;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Calendar_32;
            pictureBox7.Location = new Point(783, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 43;
            pictureBox7.TabStop = false;
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Location = new Point(213, 29);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(49, 23);
            lblApplicationID.TabIndex = 35;
            lblApplicationID.Text = "[???]";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(175, 103);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.money_32;
            pictureBox5.Location = new Point(488, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.LocalDriving_License;
            pictureBox4.Location = new Point(488, 106);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.International_32;
            pictureBox2.Location = new Point(488, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Calendar_32;
            pictureBox1.Location = new Point(175, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(645, 106);
            label8.Name = "label8";
            label8.Size = new Size(97, 23);
            label8.TabIndex = 27;
            label8.Text = "Created By:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(645, 35);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 26;
            label7.Text = "Expiration Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 112);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 25;
            label6.Text = "Local License ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 107);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 24;
            label5.Text = "Issue Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 69);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 23;
            label4.Text = "I.L.License ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 35);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 22;
            label3.Text = "Fees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 21;
            label2.Text = "Application Date:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(175, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 0;
            label1.Text = "I.L.Application ID:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 59, 48);
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(851, 475);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnIssueLicense
            // 
            btnIssueLicense.BackColor = Color.FromArgb(0, 0, 192);
            btnIssueLicense.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIssueLicense.ForeColor = Color.White;
            btnIssueLicense.ImageAlign = ContentAlignment.MiddleRight;
            btnIssueLicense.Location = new Point(851, 429);
            btnIssueLicense.Name = "btnIssueLicense";
            btnIssueLicense.Size = new Size(162, 40);
            btnIssueLicense.TabIndex = 8;
            btnIssueLicense.Text = "Issue";
            btnIssueLicense.UseVisualStyleBackColor = false;
            btnIssueLicense.Click += btnIssueLicense_Click;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenseInfo.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenseInfo.LinkColor = Color.Purple;
            llShowLicenseInfo.Location = new Point(851, 357);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(190, 27);
            llShowLicenseInfo.TabIndex = 28;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show Licenses Info";
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenseHistory.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenseHistory.LinkColor = Color.Purple;
            llShowLicenseHistory.Location = new Point(826, 305);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(218, 27);
            llShowLicenseHistory.TabIndex = 29;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            // 
            // frmNewInternationalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1130, 749);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnIssueLicense);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Name = "frmNewInternationalLicenseApplication";
            Text = "frmNewInternationalLicenseApplication";
            WindowState = FormWindowState.Maximized;
            Activated += frmNewInternationalLicenseApplication_Activated;
            Load += frmNewInternationalLicenseApplication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label lblApplicationID;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Button btnClose;
        private Button btnIssueLicense;
        private LinkLabel llShowLicenseInfo;
        private LinkLabel llShowLicenseHistory;
        private Label lblCreatedByUser;
        private Label lblExpirationDate;
        private Label lblInternationalLicenseID;
        private Label lblLocalLicenseID;
        private Label lblFees;
        private Label lblIssueDate;
        private Label lblApplicationDate;
    }
}