namespace DVLD.Applications
{
    partial class ctrlDrivingLicenseApplicationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDrivingLicenseApplicationInfo));
            groupBox1 = new GroupBox();
            llShowLicenceInfo = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblLocalDrivingLicenseApplicationID = new Label();
            lblPassedTests = new Label();
            lblAppliedFor = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ctrlApplicationBasicInfo1 = new ctrlApplicationBasicInfo();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(llShowLicenceInfo);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblLocalDrivingLicenseApplicationID);
            groupBox1.Controls.Add(lblPassedTests);
            groupBox1.Controls.Add(lblAppliedFor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(760, 102);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driving License Application Info";
            // 
            // llShowLicenceInfo
            // 
            llShowLicenceInfo.AutoSize = true;
            llShowLicenceInfo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llShowLicenceInfo.LinkBehavior = LinkBehavior.NeverUnderline;
            llShowLicenceInfo.Location = new Point(4, 57);
            llShowLicenceInfo.Name = "llShowLicenceInfo";
            llShowLicenceInfo.Size = new Size(181, 27);
            llShowLicenceInfo.TabIndex = 16;
            llShowLicenceInfo.TabStop = true;
            llShowLicenceInfo.Text = "Show License Info";
            llShowLicenceInfo.LinkClicked += llShowLicenceInfo_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.PassedTests_32;
            pictureBox3.Location = new Point(495, 57);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.License_View_321;
            pictureBox2.Location = new Point(495, 22);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 27);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            lblLocalDrivingLicenseApplicationID.AutoSize = true;
            lblLocalDrivingLicenseApplicationID.Location = new Point(171, 27);
            lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            lblLocalDrivingLicenseApplicationID.Size = new Size(45, 27);
            lblLocalDrivingLicenseApplicationID.TabIndex = 6;
            lblLocalDrivingLicenseApplicationID.Text = "???";
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.Location = new Point(542, 57);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(24, 27);
            lblPassedTests.TabIndex = 5;
            lblPassedTests.Text = "0";
            lblPassedTests.Click += lblPassedTests_Click;
            // 
            // lblAppliedFor
            // 
            lblAppliedFor.AutoSize = true;
            lblAppliedFor.Location = new Point(542, 27);
            lblAppliedFor.Name = "lblAppliedFor";
            lblAppliedFor.Size = new Size(45, 27);
            lblAppliedFor.TabIndex = 4;
            lblAppliedFor.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 57);
            label4.Name = "label4";
            label4.Size = new Size(140, 27);
            label4.TabIndex = 3;
            label4.Text = "Passed Tests:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 27);
            label2.Name = "label2";
            label2.Size = new Size(199, 27);
            label2.TabIndex = 1;
            label2.Text = "Applied For License:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 27);
            label1.TabIndex = 0;
            label1.Text = "D.L.App ID:";
            // 
            // ctrlApplicationBasicInfo1
            // 
            ctrlApplicationBasicInfo1.Location = new Point(8, 108);
            ctrlApplicationBasicInfo1.Margin = new Padding(3, 2, 3, 2);
            ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            ctrlApplicationBasicInfo1.Size = new Size(762, 285);
            ctrlApplicationBasicInfo1.TabIndex = 1;
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlApplicationBasicInfo1);
            Controls.Add(groupBox1);
            Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ctrlDrivingLicenseApplicationInfo";
            Size = new Size(794, 393);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblPassedTests;
        private Label lblAppliedFor;
        private Label lblLocalDrivingLicenseApplicationID;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel llShowLicenceInfo;
        private ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
    }
}
