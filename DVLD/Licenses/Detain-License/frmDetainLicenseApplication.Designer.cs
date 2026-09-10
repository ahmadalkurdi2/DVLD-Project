namespace DVLD.Licenses.Detain_License
{
    partial class frmDetainLicenseApplication
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            gbDetainInfo = new GroupBox();
            txtFineFees = new TextBox();
            lblCreatedBy = new Label();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            lblLicenseID = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            lblDetainDate = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lblDetainID = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnDetain = new Button();
            llShowLicenseHistory = new LinkLabel();
            llShowLicenseInfo = new LinkLabel();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(509, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 45);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Detain License";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 90);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1251, 436);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 11;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // gbDetainInfo
            // 
            gbDetainInfo.Controls.Add(txtFineFees);
            gbDetainInfo.Controls.Add(lblCreatedBy);
            gbDetainInfo.Controls.Add(pictureBox5);
            gbDetainInfo.Controls.Add(label9);
            gbDetainInfo.Controls.Add(lblLicenseID);
            gbDetainInfo.Controls.Add(pictureBox3);
            gbDetainInfo.Controls.Add(label5);
            gbDetainInfo.Controls.Add(pictureBox4);
            gbDetainInfo.Controls.Add(label7);
            gbDetainInfo.Controls.Add(lblDetainDate);
            gbDetainInfo.Controls.Add(pictureBox2);
            gbDetainInfo.Controls.Add(label3);
            gbDetainInfo.Controls.Add(lblDetainID);
            gbDetainInfo.Controls.Add(pictureBox1);
            gbDetainInfo.Controls.Add(label1);
            gbDetainInfo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDetainInfo.Location = new Point(22, 532);
            gbDetainInfo.Name = "gbDetainInfo";
            gbDetainInfo.Size = new Size(1201, 211);
            gbDetainInfo.TabIndex = 12;
            gbDetainInfo.TabStop = false;
            gbDetainInfo.Text = "Detain Info";
            // 
            // txtFineFees
            // 
            txtFineFees.Location = new Point(591, 39);
            txtFineFees.Name = "txtFineFees";
            txtFineFees.Size = new Size(142, 34);
            txtFineFees.TabIndex = 65;
            txtFineFees.Validating += txtFineFees_Validating;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(602, 111);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(45, 27);
            lblCreatedBy.TabIndex = 64;
            lblCreatedBy.Text = "???";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.User_32__2;
            pictureBox5.Location = new Point(564, 106);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 63;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(435, 111);
            label9.Name = "label9";
            label9.Size = new Size(125, 27);
            label9.TabIndex = 62;
            label9.Text = "Created By:";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseID.Location = new Point(949, 46);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(45, 27);
            lblLicenseID.TabIndex = 61;
            lblLicenseID.Text = "???";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LocalDriving_License;
            pictureBox3.Location = new Point(911, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(793, 46);
            label5.Name = "label5";
            label5.Size = new Size(118, 27);
            label5.TabIndex = 59;
            label5.Text = "License ID:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(553, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 57;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(435, 46);
            label7.Name = "label7";
            label7.Size = new Size(109, 27);
            label7.TabIndex = 56;
            label7.Text = "Fine Fees:";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainDate.Location = new Point(193, 111);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(45, 27);
            lblDetainDate.TabIndex = 55;
            lblDetainDate.Text = "???";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(155, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 111);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 53;
            label3.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainID.Location = new Point(193, 46);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(45, 27);
            lblDetainID.TabIndex = 52;
            lblDetainID.Text = "???";
            lblDetainID.Click += lblDetainID_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(155, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(112, 27);
            label1.TabIndex = 0;
            label1.Text = "Detain ID:";
            // 
            // btnDetain
            // 
            btnDetain.BackColor = Color.Purple;
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetain.ForeColor = Color.White;
            btnDetain.ImageAlign = ContentAlignment.MiddleRight;
            btnDetain.Location = new Point(875, 781);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(171, 40);
            btnDetain.TabIndex = 40;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = false;
            btnDetain.Click += btnDetain_Click;
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenseHistory.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenseHistory.LinkColor = Color.Purple;
            llShowLicenseHistory.Location = new Point(21, 787);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(218, 27);
            llShowLicenseHistory.TabIndex = 39;
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
            llShowLicenseInfo.Location = new Point(259, 787);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(237, 27);
            llShowLicenseInfo.TabIndex = 38;
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
            btnClose.Location = new Point(1052, 781);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 40);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1282, 749);
            Controls.Add(btnDetain);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(gbDetainInfo);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(lblTitle);
            Name = "frmDetainLicenseApplication";
            Text = "frmDetainLicenseApplication";
            WindowState = FormWindowState.Maximized;
            Activated += frmDetainLicenseApplication_Activated;
            Load += frmDetainLicenseApplication_Load;
            gbDetainInfo.ResumeLayout(false);
            gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox gbDetainInfo;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblDetainID;
        private Label lblCreatedBy;
        private PictureBox pictureBox5;
        private Label label9;
        private Label lblLicenseID;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox4;
        private Label label7;
        private Label lblDetainDate;
        private PictureBox pictureBox2;
        private Label label3;
        private Button btnDetain;
        private LinkLabel llShowLicenseHistory;
        private LinkLabel llShowLicenseInfo;
        private Button btnClose;
        private TextBox txtFineFees;
        private ErrorProvider errorProvider1;
    }
}