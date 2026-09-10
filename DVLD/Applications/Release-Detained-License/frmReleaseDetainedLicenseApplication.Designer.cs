namespace DVLD.Applications.Release_Detained_License
{
    partial class frmReleaseDetainedLicenseApplication
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
            lblTitle = new Label();
            ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            gbDetain = new GroupBox();
            lblApplicationID = new Label();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            lblFineFees = new Label();
            pictureBox6 = new PictureBox();
            label10 = new Label();
            lblCreatedBy = new Label();
            pictureBox7 = new PictureBox();
            label12 = new Label();
            lblLicenseID = new Label();
            pictureBox8 = new PictureBox();
            label14 = new Label();
            lblTotalFees = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            lblApplicationFees = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            lblDetainDate = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblDetainID = new Label();
            pictureBox1 = new PictureBox();
            DetainID = new Label();
            btnRelease = new Button();
            llShowLicenseHistory = new LinkLabel();
            llShowLicenseInfo = new LinkLabel();
            btnClose = new Button();
            gbDetain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(405, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(428, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Release Detained License ";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 95);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1251, 436);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 4;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // gbDetain
            // 
            gbDetain.Controls.Add(lblApplicationID);
            gbDetain.Controls.Add(pictureBox5);
            gbDetain.Controls.Add(label8);
            gbDetain.Controls.Add(lblFineFees);
            gbDetain.Controls.Add(pictureBox6);
            gbDetain.Controls.Add(label10);
            gbDetain.Controls.Add(lblCreatedBy);
            gbDetain.Controls.Add(pictureBox7);
            gbDetain.Controls.Add(label12);
            gbDetain.Controls.Add(lblLicenseID);
            gbDetain.Controls.Add(pictureBox8);
            gbDetain.Controls.Add(label14);
            gbDetain.Controls.Add(lblTotalFees);
            gbDetain.Controls.Add(pictureBox4);
            gbDetain.Controls.Add(label6);
            gbDetain.Controls.Add(lblApplicationFees);
            gbDetain.Controls.Add(pictureBox3);
            gbDetain.Controls.Add(label4);
            gbDetain.Controls.Add(lblDetainDate);
            gbDetain.Controls.Add(pictureBox2);
            gbDetain.Controls.Add(label2);
            gbDetain.Controls.Add(lblDetainID);
            gbDetain.Controls.Add(pictureBox1);
            gbDetain.Controls.Add(DetainID);
            gbDetain.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDetain.Location = new Point(21, 546);
            gbDetain.Name = "gbDetain";
            gbDetain.Size = new Size(1205, 224);
            gbDetain.TabIndex = 5;
            gbDetain.TabStop = false;
            gbDetain.Text = "Detain Info";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.Location = new Point(801, 170);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(45, 27);
            lblApplicationID.TabIndex = 74;
            lblApplicationID.Text = "???";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Number_32;
            pictureBox5.Location = new Point(747, 165);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 73;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(591, 170);
            label8.Name = "label8";
            label8.Size = new Size(151, 27);
            label8.TabIndex = 72;
            label8.Text = "Application ID:";
            // 
            // lblFineFees
            // 
            lblFineFees.AutoSize = true;
            lblFineFees.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFineFees.Location = new Point(801, 124);
            lblFineFees.Name = "lblFineFees";
            lblFineFees.Size = new Size(45, 27);
            lblFineFees.TabIndex = 71;
            lblFineFees.Text = "???";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.money_32;
            pictureBox6.Location = new Point(747, 124);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 70;
            pictureBox6.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(591, 124);
            label10.Name = "label10";
            label10.Size = new Size(109, 27);
            label10.TabIndex = 69;
            label10.Text = "Fine Fees:";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(801, 83);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(45, 27);
            lblCreatedBy.TabIndex = 68;
            lblCreatedBy.Text = "???";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.User_32__2;
            pictureBox7.Location = new Point(747, 78);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 67;
            pictureBox7.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(591, 78);
            label12.Name = "label12";
            label12.Size = new Size(125, 27);
            label12.TabIndex = 66;
            label12.Text = "Created By:";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseID.Location = new Point(801, 40);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(45, 27);
            lblLicenseID.TabIndex = 65;
            lblLicenseID.Text = "???";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.LocalDriving_License;
            pictureBox8.Location = new Point(747, 33);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 32);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 64;
            pictureBox8.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(591, 35);
            label14.Name = "label14";
            label14.Size = new Size(118, 27);
            label14.TabIndex = 63;
            label14.Text = "License ID:";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.Location = new Point(228, 165);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(45, 27);
            lblTotalFees.TabIndex = 62;
            lblTotalFees.Text = "???";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(190, 165);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 61;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 165);
            label6.Name = "label6";
            label6.Size = new Size(119, 27);
            label6.TabIndex = 60;
            label6.Text = "Total Fees:";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(228, 124);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(45, 27);
            lblApplicationFees.TabIndex = 59;
            lblApplicationFees.Text = "???";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(190, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 119);
            label4.Name = "label4";
            label4.Size = new Size(170, 27);
            label4.TabIndex = 57;
            label4.Text = "Application Fees:";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainDate.Location = new Point(228, 73);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(45, 27);
            lblDetainDate.TabIndex = 56;
            lblDetainDate.Text = "???";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(190, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(133, 27);
            label2.TabIndex = 54;
            label2.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainID.Location = new Point(228, 30);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(45, 27);
            lblDetainID.TabIndex = 53;
            lblDetainID.Text = "???";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(190, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // DetainID
            // 
            DetainID.AutoSize = true;
            DetainID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetainID.Location = new Point(21, 30);
            DetainID.Name = "DetainID";
            DetainID.Size = new Size(112, 27);
            DetainID.TabIndex = 0;
            DetainID.Text = "Detain ID:";
            // 
            // btnRelease
            // 
            btnRelease.BackColor = Color.Purple;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelease.ForeColor = Color.White;
            btnRelease.ImageAlign = ContentAlignment.MiddleRight;
            btnRelease.Location = new Point(877, 815);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(171, 40);
            btnRelease.TabIndex = 44;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = false;
            btnRelease.Click += btnRelease_Click;
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenseHistory.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenseHistory.LinkColor = Color.Purple;
            llShowLicenseHistory.Location = new Point(23, 821);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(218, 27);
            llShowLicenseHistory.TabIndex = 43;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            llShowLicenseHistory.LinkClicked += llShowLicenseHistory_LinkClicked;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenseInfo.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenseInfo.LinkColor = Color.Purple;
            llShowLicenseInfo.Location = new Point(261, 821);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(190, 27);
            llShowLicenseInfo.TabIndex = 42;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(1054, 815);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 40);
            btnClose.TabIndex = 41;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmReleaseDetainedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1254, 749);
            Controls.Add(btnRelease);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(gbDetain);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(lblTitle);
            Name = "frmReleaseDetainedLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReleaseDetainedLicenseApplication";
            WindowState = FormWindowState.Maximized;
            Activated += frmReleaseDetainedLicenseApplication_Activated;
            gbDetain.ResumeLayout(false);
            gbDetain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox gbDetain;
        private Label DetainID;
        private PictureBox pictureBox1;
        private Label lblDetainID;
        private Label lblApplicationID;
        private PictureBox pictureBox5;
        private Label label8;
        private Label lblFineFees;
        private PictureBox pictureBox6;
        private Label label10;
        private Label lblCreatedBy;
        private PictureBox pictureBox7;
        private Label label12;
        private Label lblLicenseID;
        private PictureBox pictureBox8;
        private Label label14;
        private Label lblTotalFees;
        private PictureBox pictureBox4;
        private Label label6;
        private Label lblApplicationFees;
        private PictureBox pictureBox3;
        private Label label4;
        private Label lblDetainDate;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnRelease;
        private LinkLabel llShowLicenseHistory;
        private LinkLabel llShowLicenseInfo;
        private Button btnClose;
    }
}