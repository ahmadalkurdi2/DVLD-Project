namespace DVLD.Applications.Renew_Local_License
{
    partial class frmRenewLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLocalDrivingLicenseApplication));
            lblTitle = new Label();
            btnClose = new Button();
            ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            gpApplicationInfo = new GroupBox();
            txtNotes = new TextBox();
            lblApplicationDate = new Label();
            pictureBox11 = new PictureBox();
            label = new Label();
            lblLicenseFees = new Label();
            pictureBox10 = new PictureBox();
            label20 = new Label();
            lblApplicationFees = new Label();
            pictureBox9 = new PictureBox();
            label18 = new Label();
            lblIssueDate = new Label();
            pictureBox8 = new PictureBox();
            label16 = new Label();
            lblRenewedLicenseID = new Label();
            pictureBox7 = new PictureBox();
            label14 = new Label();
            lblOldLicenseID = new Label();
            pictureBox6 = new PictureBox();
            label12 = new Label();
            lblCreatedBy = new Label();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            lblTotalFees = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            lblExpirationDate = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            lblApplicationID = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            llShowLicenseHistory = new LinkLabel();
            llShowLicenseInfo = new LinkLabel();
            btnRenew = new Button();
            gpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            lblTitle.Location = new Point(250, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(422, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Renew License Application";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(1051, 697);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 40);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(29, 57);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(1193, 426);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 14;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // gpApplicationInfo
            // 
            gpApplicationInfo.Controls.Add(txtNotes);
            gpApplicationInfo.Controls.Add(lblApplicationDate);
            gpApplicationInfo.Controls.Add(pictureBox11);
            gpApplicationInfo.Controls.Add(label);
            gpApplicationInfo.Controls.Add(lblLicenseFees);
            gpApplicationInfo.Controls.Add(pictureBox10);
            gpApplicationInfo.Controls.Add(label20);
            gpApplicationInfo.Controls.Add(lblApplicationFees);
            gpApplicationInfo.Controls.Add(pictureBox9);
            gpApplicationInfo.Controls.Add(label18);
            gpApplicationInfo.Controls.Add(lblIssueDate);
            gpApplicationInfo.Controls.Add(pictureBox8);
            gpApplicationInfo.Controls.Add(label16);
            gpApplicationInfo.Controls.Add(lblRenewedLicenseID);
            gpApplicationInfo.Controls.Add(pictureBox7);
            gpApplicationInfo.Controls.Add(label14);
            gpApplicationInfo.Controls.Add(lblOldLicenseID);
            gpApplicationInfo.Controls.Add(pictureBox6);
            gpApplicationInfo.Controls.Add(label12);
            gpApplicationInfo.Controls.Add(lblCreatedBy);
            gpApplicationInfo.Controls.Add(pictureBox5);
            gpApplicationInfo.Controls.Add(label10);
            gpApplicationInfo.Controls.Add(lblTotalFees);
            gpApplicationInfo.Controls.Add(pictureBox4);
            gpApplicationInfo.Controls.Add(label8);
            gpApplicationInfo.Controls.Add(pictureBox3);
            gpApplicationInfo.Controls.Add(label6);
            gpApplicationInfo.Controls.Add(lblExpirationDate);
            gpApplicationInfo.Controls.Add(pictureBox2);
            gpApplicationInfo.Controls.Add(label4);
            gpApplicationInfo.Controls.Add(lblApplicationID);
            gpApplicationInfo.Controls.Add(pictureBox1);
            gpApplicationInfo.Controls.Add(label1);
            gpApplicationInfo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpApplicationInfo.Location = new Point(12, 489);
            gpApplicationInfo.Name = "gpApplicationInfo";
            gpApplicationInfo.Size = new Size(1210, 191);
            gpApplicationInfo.TabIndex = 15;
            gpApplicationInfo.TabStop = false;
            gpApplicationInfo.Text = "Application New License Info";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(879, 74);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(325, 108);
            txtNotes.TabIndex = 46;
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(248, 62);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(45, 27);
            lblApplicationDate.TabIndex = 45;
            lblApplicationDate.Text = "???";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Calendar_32;
            pictureBox11.Location = new Point(214, 57);
            pictureBox11.Margin = new Padding(3, 2, 3, 2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(32, 32);
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.TabIndex = 44;
            pictureBox11.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(15, 57);
            label.Name = "label";
            label.Size = new Size(172, 27);
            label.TabIndex = 43;
            label.Text = "Application Date:";
            // 
            // lblLicenseFees
            // 
            lblLicenseFees.AutoSize = true;
            lblLicenseFees.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseFees.Location = new Point(248, 154);
            lblLicenseFees.Name = "lblLicenseFees";
            lblLicenseFees.Size = new Size(45, 27);
            lblLicenseFees.TabIndex = 42;
            lblLicenseFees.Text = "???";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.money_32;
            pictureBox10.Location = new Point(214, 154);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(32, 32);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 41;
            pictureBox10.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(19, 159);
            label20.Name = "label20";
            label20.Size = new Size(137, 27);
            label20.TabIndex = 40;
            label20.Text = "License Fees:";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.Location = new Point(252, 116);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(45, 27);
            lblApplicationFees.TabIndex = 39;
            lblApplicationFees.Text = "???";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.money_32;
            pictureBox9.Location = new Point(214, 123);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 32);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 38;
            pictureBox9.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(19, 119);
            label18.Name = "label18";
            label18.Size = new Size(170, 27);
            label18.TabIndex = 37;
            label18.Text = "Application Fees:";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssueDate.Location = new Point(252, 92);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(45, 27);
            lblIssueDate.TabIndex = 36;
            lblIssueDate.Text = "???";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Calendar_32;
            pictureBox8.Location = new Point(214, 92);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 32);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 35;
            pictureBox8.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(19, 87);
            label16.Name = "label16";
            label16.Size = new Size(122, 27);
            label16.TabIndex = 34;
            label16.Text = "Issue Date:";
            // 
            // lblRenewedLicenseID
            // 
            lblRenewedLicenseID.AutoSize = true;
            lblRenewedLicenseID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRenewedLicenseID.Location = new Point(615, 30);
            lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            lblRenewedLicenseID.Size = new Size(45, 27);
            lblRenewedLicenseID.TabIndex = 33;
            lblRenewedLicenseID.Text = "???";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Renew_Driving_License_321;
            pictureBox7.Location = new Point(577, 30);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(372, 35);
            label14.Name = "label14";
            label14.Size = new Size(205, 27);
            label14.TabIndex = 31;
            label14.Text = "Renewed License ID:";
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldLicenseID.Location = new Point(615, 57);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(45, 27);
            lblOldLicenseID.TabIndex = 30;
            lblOldLicenseID.Text = "???";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.LocalDriving_License;
            pictureBox6.Location = new Point(577, 57);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(372, 62);
            label12.Name = "label12";
            label12.Size = new Size(157, 27);
            label12.TabIndex = 28;
            label12.Text = "Old License ID:";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(615, 150);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(45, 27);
            lblCreatedBy.TabIndex = 27;
            lblCreatedBy.Text = "???";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.User_32__2;
            pictureBox5.Location = new Point(577, 145);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(372, 143);
            label10.Name = "label10";
            label10.Size = new Size(125, 27);
            label10.TabIndex = 25;
            label10.Text = "Created By:";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.Location = new Point(923, 30);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(45, 27);
            lblTotalFees.TabIndex = 24;
            lblTotalFees.Text = "???";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(885, 30);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(372, 116);
            label8.Name = "label8";
            label8.Size = new Size(165, 27);
            label8.TabIndex = 22;
            label8.Text = "Expiration Date:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Notes_32;
            pictureBox3.Location = new Point(830, 74);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(760, 30);
            label6.Name = "label6";
            label6.Size = new Size(119, 27);
            label6.TabIndex = 19;
            label6.Text = "Total Fees:";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpirationDate.Location = new Point(615, 111);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(45, 27);
            lblExpirationDate.TabIndex = 18;
            lblExpirationDate.Text = "???";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_32;
            pictureBox2.Location = new Point(577, 111);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(760, 74);
            label4.Name = "label4";
            label4.Size = new Size(74, 27);
            label4.TabIndex = 16;
            label4.Text = "Notes:";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.Location = new Point(248, 35);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(45, 27);
            lblApplicationID.TabIndex = 15;
            lblApplicationID.Text = "???";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 30);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(189, 27);
            label1.TabIndex = 0;
            label1.Text = "R.L.Application ID:";
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenseHistory.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenseHistory.LinkColor = Color.Purple;
            llShowLicenseHistory.Location = new Point(12, 703);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(218, 27);
            llShowLicenseHistory.TabIndex = 31;
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
            llShowLicenseInfo.Location = new Point(250, 703);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(237, 27);
            llShowLicenseInfo.TabIndex = 30;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show New Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // btnRenew
            // 
            btnRenew.BackColor = Color.Purple;
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRenew.ForeColor = Color.White;
            btnRenew.ImageAlign = ContentAlignment.MiddleRight;
            btnRenew.Location = new Point(874, 697);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(171, 40);
            btnRenew.TabIndex = 32;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = false;
            btnRenew.Click += btnRenew_Click;
            // 
            // frmRenewLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1280, 749);
            Controls.Add(btnRenew);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(btnClose);
            Controls.Add(gpApplicationInfo);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            Controls.Add(lblTitle);
            Name = "frmRenewLocalDrivingLicenseApplication";
            Text = "frmRenewLocalDrivingLicenseApplication";
            WindowState = FormWindowState.Maximized;
            Activated += frmRenewLocalDrivingLicenseApplication_Activated;
            Load += frmRenewLocalDrivingLicenseApplication_Load;
            gpApplicationInfo.ResumeLayout(false);
            gpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnClose;
        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox gpApplicationInfo;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblApplicationID;
        private Label lblApplicationDate;
        private PictureBox pictureBox11;
        private Label label;
        private Label lblLicenseFees;
        private PictureBox pictureBox10;
        private Label label20;
        private Label lblApplicationFees;
        private PictureBox pictureBox9;
        private Label label18;
        private Label lblIssueDate;
        private PictureBox pictureBox8;
        private Label label16;
        private Label lblRenewedLicenseID;
        private PictureBox pictureBox7;
        private Label label14;
        private Label lblOldLicenseID;
        private PictureBox pictureBox6;
        private Label label12;
        private Label lblCreatedBy;
        private PictureBox pictureBox5;
        private Label label10;
        private Label lblTotalFees;
        private PictureBox pictureBox4;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label6;
        private Label lblExpirationDate;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox txtNotes;
        private LinkLabel llShowLicenseHistory;
        private LinkLabel llShowLicenseInfo;
        private Button btnRenew;
    }
}