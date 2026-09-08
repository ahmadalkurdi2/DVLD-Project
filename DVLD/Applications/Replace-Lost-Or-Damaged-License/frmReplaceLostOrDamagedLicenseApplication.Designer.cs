namespace DVLD.Applications.Replace_Lost_Or_Damaged_License
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceLostOrDamagedLicenseApplication));
            lblTitle = new Label();
            btnReplacement = new Button();
            llShowLicenseHistory = new LinkLabel();
            llShowLicenseInfo = new LinkLabel();
            btnClose = new Button();
            ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            gbReplacementFor = new GroupBox();
            rbLost = new RadioButton();
            rbDamaged = new RadioButton();
            groupBox1 = new GroupBox();
            lblCreatedBy = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            lblOldLicenseID = new Label();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            lblRreplacedLicenseID = new Label();
            pictureBox6 = new PictureBox();
            label11 = new Label();
            lblApplicationFees = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            lblApplicationDate = new Label();
            pictureBox2 = new PictureBox();
            label = new Label();
            lblApplicationID = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            gbReplacementFor.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            lblTitle.Location = new Point(462, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 45);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "License Replacement";
            // 
            // btnReplacement
            // 
            btnReplacement.BackColor = Color.Purple;
            btnReplacement.FlatStyle = FlatStyle.Flat;
            btnReplacement.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReplacement.ForeColor = Color.White;
            btnReplacement.ImageAlign = ContentAlignment.MiddleRight;
            btnReplacement.Location = new Point(844, 681);
            btnReplacement.Name = "btnReplacement";
            btnReplacement.Size = new Size(208, 40);
            btnReplacement.TabIndex = 36;
            btnReplacement.Text = "Issue Replacement";
            btnReplacement.UseVisualStyleBackColor = false;
            btnReplacement.Click += btnReplacement_Click;
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenseHistory.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenseHistory.LinkColor = Color.Purple;
            llShowLicenseHistory.Location = new Point(39, 687);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(218, 27);
            llShowLicenseHistory.TabIndex = 35;
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
            llShowLicenseInfo.Location = new Point(277, 687);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(237, 27);
            llShowLicenseInfo.TabIndex = 34;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show New Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(1067, 681);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 40);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(27, 75);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1228, 436);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 37;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // gbReplacementFor
            // 
            gbReplacementFor.Controls.Add(rbLost);
            gbReplacementFor.Controls.Add(rbDamaged);
            gbReplacementFor.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbReplacementFor.Location = new Point(814, 75);
            gbReplacementFor.Name = "gbReplacementFor";
            gbReplacementFor.Size = new Size(238, 108);
            gbReplacementFor.TabIndex = 38;
            gbReplacementFor.TabStop = false;
            gbReplacementFor.Text = "Replacement For:";
            // 
            // rbLost
            // 
            rbLost.AutoSize = true;
            rbLost.Location = new Point(30, 67);
            rbLost.Name = "rbLost";
            rbLost.Size = new Size(117, 27);
            rbLost.TabIndex = 1;
            rbLost.TabStop = true;
            rbLost.Text = "Lost License";
            rbLost.UseVisualStyleBackColor = true;
            rbLost.CheckedChanged += rbLost_CheckedChanged;
            // 
            // rbDamaged
            // 
            rbDamaged.AutoSize = true;
            rbDamaged.Location = new Point(30, 31);
            rbDamaged.Name = "rbDamaged";
            rbDamaged.Size = new Size(150, 27);
            rbDamaged.TabIndex = 0;
            rbDamaged.TabStop = true;
            rbDamaged.Text = "Damaged License";
            rbDamaged.UseVisualStyleBackColor = true;
            rbDamaged.CheckedChanged += rbDamaged_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblOldLicenseID);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblRreplacedLicenseID);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblApplicationFees);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblApplicationDate);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(lblApplicationID);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(39, 517);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1199, 145);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info for License Replacement";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(686, 109);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(45, 27);
            lblCreatedBy.TabIndex = 31;
            lblCreatedBy.Text = "???";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.User_32__2;
            pictureBox4.Location = new Point(636, 109);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(423, 109);
            label7.Name = "label7";
            label7.Size = new Size(125, 27);
            label7.TabIndex = 29;
            label7.Text = "Created By:";
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldLicenseID.Location = new Point(686, 73);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(45, 27);
            lblOldLicenseID.TabIndex = 28;
            lblOldLicenseID.Text = "???";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.LocalDriving_License;
            pictureBox5.Location = new Point(636, 73);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(423, 73);
            label9.Name = "label9";
            label9.Size = new Size(157, 27);
            label9.TabIndex = 26;
            label9.Text = "Old License ID:";
            // 
            // lblRreplacedLicenseID
            // 
            lblRreplacedLicenseID.AutoSize = true;
            lblRreplacedLicenseID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRreplacedLicenseID.Location = new Point(686, 37);
            lblRreplacedLicenseID.Name = "lblRreplacedLicenseID";
            lblRreplacedLicenseID.Size = new Size(45, 27);
            lblRreplacedLicenseID.TabIndex = 25;
            lblRreplacedLicenseID.Text = "???";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Renew_Driving_License_32;
            pictureBox6.Location = new Point(636, 34);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(423, 37);
            label11.Name = "label11";
            label11.Size = new Size(207, 27);
            label11.TabIndex = 23;
            label11.Text = "Replaced License ID:";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(239, 104);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(45, 27);
            lblApplicationFees.TabIndex = 22;
            lblApplicationFees.Text = "???";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(201, 104);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 102);
            label5.Name = "label5";
            label5.Size = new Size(170, 27);
            label5.TabIndex = 20;
            label5.Text = "Application Fees:";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(239, 68);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(45, 27);
            lblApplicationDate.TabIndex = 19;
            lblApplicationDate.Text = "???";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(201, 68);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(6, 66);
            label.Name = "label";
            label.Size = new Size(164, 27);
            label.TabIndex = 17;
            label.Text = "Application Date";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.Location = new Point(239, 32);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(45, 27);
            lblApplicationID.TabIndex = 16;
            lblApplicationID.Text = "???";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(201, 32);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(189, 27);
            label1.TabIndex = 0;
            label1.Text = "L.R.Application ID:";
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1279, 733);
            Controls.Add(groupBox1);
            Controls.Add(gbReplacementFor);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(btnReplacement);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Name = "frmReplaceLostOrDamagedLicenseApplication";
            Text = "frmReplaceLostOrDamagedLicenseApplication";
            WindowState = FormWindowState.Maximized;
            Activated += frmReplaceLostOrDamagedLicenseApplication_Activated;
            Load += frmReplaceLostOrDamagedLicenseApplication_Load;
            gbReplacementFor.ResumeLayout(false);
            gbReplacementFor.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnReplacement;
        private LinkLabel llShowLicenseHistory;
        private LinkLabel llShowLicenseInfo;
        private Button btnClose;
        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox gbReplacementFor;
        private RadioButton rbLost;
        private RadioButton rbDamaged;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblApplicationID;
        private PictureBox pictureBox1;
        private Label label;
        private Label lblCreatedBy;
        private PictureBox pictureBox4;
        private Label label7;
        private Label lblOldLicenseID;
        private PictureBox pictureBox5;
        private Label label9;
        private Label lblRreplacedLicenseID;
        private PictureBox pictureBox6;
        private Label label11;
        private Label lblApplicationFees;
        private PictureBox pictureBox3;
        private Label label5;
        private Label lblApplicationDate;
        private PictureBox pictureBox2;
    }
}