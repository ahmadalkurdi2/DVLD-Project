namespace DVLD.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateLocalDrivingLicesnseApplication));
            lblTitle = new Label();
            tcApplicationInfo = new TabControl();
            tpPersonalInfo = new TabPage();
            ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            tpApplicationInfo = new TabPage();
            cbLicenseClass = new ComboBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            lblCreatedByUser = new Label();
            lblFees = new Label();
            lblApplicationDate = new Label();
            lblLocalDrivingLicenseApplicationID = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            btnSave1 = new Button();
            tcApplicationInfo.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(323, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(525, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Local Driving License Application";
            // 
            // tcApplicationInfo
            // 
            tcApplicationInfo.Controls.Add(tpPersonalInfo);
            tcApplicationInfo.Controls.Add(tpApplicationInfo);
            tcApplicationInfo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tcApplicationInfo.Location = new Point(12, 109);
            tcApplicationInfo.Name = "tcApplicationInfo";
            tcApplicationInfo.SelectedIndex = 0;
            tcApplicationInfo.Size = new Size(1085, 507);
            tcApplicationInfo.TabIndex = 3;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonalInfo.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpPersonalInfo.Location = new Point(4, 36);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(3);
            tpPersonalInfo.Size = new Size(1077, 467);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "Personal Info";
            tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.Location = new Point(27, 6);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(1020, 504);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpApplicationInfo
            // 
            tpApplicationInfo.Controls.Add(cbLicenseClass);
            tpApplicationInfo.Controls.Add(pictureBox5);
            tpApplicationInfo.Controls.Add(label6);
            tpApplicationInfo.Controls.Add(lblCreatedByUser);
            tpApplicationInfo.Controls.Add(lblFees);
            tpApplicationInfo.Controls.Add(lblApplicationDate);
            tpApplicationInfo.Controls.Add(lblLocalDrivingLicenseApplicationID);
            tpApplicationInfo.Controls.Add(pictureBox4);
            tpApplicationInfo.Controls.Add(pictureBox3);
            tpApplicationInfo.Controls.Add(pictureBox1);
            tpApplicationInfo.Controls.Add(pictureBox2);
            tpApplicationInfo.Controls.Add(label4);
            tpApplicationInfo.Controls.Add(label3);
            tpApplicationInfo.Controls.Add(label2);
            tpApplicationInfo.Controls.Add(label1);
            tpApplicationInfo.Location = new Point(4, 36);
            tpApplicationInfo.Name = "tpApplicationInfo";
            tpApplicationInfo.Padding = new Padding(3);
            tpApplicationInfo.Size = new Size(1077, 467);
            tpApplicationInfo.TabIndex = 1;
            tpApplicationInfo.Text = "Application Info";
            tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(307, 151);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(271, 35);
            cbLicenseClass.TabIndex = 21;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(248, 151);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 156);
            label6.Name = "label6";
            label6.Size = new Size(140, 27);
            label6.TabIndex = 19;
            label6.Text = "License Class:";
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Location = new Point(307, 255);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(70, 27);
            lblCreatedByUser.TabIndex = 18;
            lblCreatedByUser.Text = "[????]";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(307, 202);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(65, 27);
            lblFees.TabIndex = 17;
            lblFees.Text = "[$$$]";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Location = new Point(307, 104);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(134, 27);
            lblApplicationDate.TabIndex = 16;
            lblApplicationDate.Text = "[??/??/????]";
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            lblLocalDrivingLicenseApplicationID.AutoSize = true;
            lblLocalDrivingLicenseApplicationID.Location = new Point(307, 44);
            lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            lblLocalDrivingLicenseApplicationID.Size = new Size(59, 27);
            lblLocalDrivingLicenseApplicationID.TabIndex = 15;
            lblLocalDrivingLicenseApplicationID.Text = "[???]";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(246, 202);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(246, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(246, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(246, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 255);
            label4.Name = "label4";
            label4.Size = new Size(125, 27);
            label4.TabIndex = 3;
            label4.Text = "Created By:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 207);
            label3.Name = "label3";
            label3.Size = new Size(170, 27);
            label3.TabIndex = 2;
            label3.Text = "Application Fees:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 104);
            label2.Name = "label2";
            label2.Size = new Size(172, 27);
            label2.TabIndex = 1;
            label2.Text = "Application Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 44);
            label1.Name = "label1";
            label1.Size = new Size(191, 27);
            label1.TabIndex = 0;
            label1.Text = "D.L.Application ID:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 59, 48);
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(935, 622);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave1
            // 
            btnSave1.BackColor = Color.Green;
            btnSave1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave1.ForeColor = Color.White;
            btnSave1.ImageAlign = ContentAlignment.MiddleRight;
            btnSave1.Location = new Point(778, 622);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(151, 40);
            btnSave1.TabIndex = 50;
            btnSave1.Text = "Save";
            btnSave1.UseVisualStyleBackColor = false;
            // 
            // frmAddUpdateLocalDrivingLicesnseApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1213, 673);
            Controls.Add(btnSave1);
            Controls.Add(btnClose);
            Controls.Add(tcApplicationInfo);
            Controls.Add(lblTitle);
            Name = "frmAddUpdateLocalDrivingLicesnseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateLocalDrivingLicesnseApplication";
            tcApplicationInfo.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpApplicationInfo.ResumeLayout(false);
            tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tcApplicationInfo;
        private TabPage tpPersonalInfo;
        private TabPage tpApplicationInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblCreatedByUser;
        private Label lblFees;
        private Label lblApplicationDate;
        private Label lblLocalDrivingLicenseApplicationID;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private ComboBox cbLicenseClass;
        private PictureBox pictureBox5;
        private Label label6;
        private Button btnClose;
        private Button btnSave1;
    }
}