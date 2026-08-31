namespace DVLD.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicesnseApplications
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            btnAddNewApplication = new Button();
            dgvLocalDrivingLicenseApplications = new DataGridView();
            btnClose = new Button();
            label2 = new Label();
            lblRecordsCount = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            DeleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            CancelApplicaitonToolStripMenuItem = new ToolStripMenuItem();
            ScheduleTestsMenue = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(543, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Local_32;
            pictureBox2.Location = new Point(702, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(355, 228);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(541, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Local Driving License Applications";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 323);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 3;
            label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(104, 323);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(239, 23);
            cbFilterBy.TabIndex = 4;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(355, 323);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(255, 23);
            txtFilterValue.TabIndex = 5;
            txtFilterValue.Visible = false;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // btnAddNewApplication
            // 
            btnAddNewApplication.BackColor = Color.Transparent;
            btnAddNewApplication.Image = Properties.Resources.New_Application_64;
            btnAddNewApplication.Location = new Point(1132, 292);
            btnAddNewApplication.Name = "btnAddNewApplication";
            btnAddNewApplication.Size = new Size(97, 82);
            btnAddNewApplication.TabIndex = 6;
            btnAddNewApplication.UseVisualStyleBackColor = false;
            btnAddNewApplication.Click += btnAddNewApplication_Click;
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenseApplications.Location = new Point(12, 399);
            dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            dgvLocalDrivingLicenseApplications.Size = new Size(1217, 250);
            dgvLocalDrivingLicenseApplications.TabIndex = 7;
            dgvLocalDrivingLicenseApplications.ContextMenuStrip = contextMenuStrip1;
            dgvLocalDrivingLicenseApplications.MouseDown += dgvLocalDrivingLicenseApplications_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(1067, 662);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 671);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 9;
            label2.Text = "Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(95, 671);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(37, 23);
            lblRecordsCount.TabIndex = 10;
            lblRecordsCount.Text = "???";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, editToolStripMenuItem, DeleteApplicationToolStripMenuItem, CancelApplicaitonToolStripMenuItem, ScheduleTestsMenue, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(280, 308);
            contextMenuStrip1.AutoSize = false;
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showApplicationDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(279, 38);
            showApplicationDetailsToolStripMenuItem.Text = "&Show Application Details";
            showApplicationDetailsToolStripMenuItem.Click += showApplicationDetailsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(279, 38);
            editToolStripMenuItem.Text = "&Edit Application";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // DeleteApplicationToolStripMenuItem
            // 
            DeleteApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            DeleteApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            DeleteApplicationToolStripMenuItem.Size = new Size(279, 38);
            DeleteApplicationToolStripMenuItem.Text = "&Delete Application";
            DeleteApplicationToolStripMenuItem.Click += DeleteApplicationToolStripMenuItem_Click;
            // 
            // CancelApplicaitonToolStripMenuItem
            // 
            CancelApplicaitonToolStripMenuItem.Image = Properties.Resources.Delete_322;
            CancelApplicaitonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            CancelApplicaitonToolStripMenuItem.Name = "CancelApplicaitonToolStripMenuItem";
            CancelApplicaitonToolStripMenuItem.Size = new Size(279, 38);
            CancelApplicaitonToolStripMenuItem.Text = "&Cancel Application";
            CancelApplicaitonToolStripMenuItem.Click += CancelApplicaitonToolStripMenuItem_Click;
            // 
            // ScheduleTestsMenue
            // 
            ScheduleTestsMenue.DropDownItems.AddRange(new ToolStripItem[] { scheduleVisionTestToolStripMenuItem, scheduleWrittenTestToolStripMenuItem, scheduleStreetTestToolStripMenuItem });
            ScheduleTestsMenue.Image = Properties.Resources.Schedule_Test_32;
            ScheduleTestsMenue.ImageScaling = ToolStripItemImageScaling.None;
            ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            ScheduleTestsMenue.Size = new Size(279, 38);
            ScheduleTestsMenue.Text = "Sechdule &Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            scheduleVisionTestToolStripMenuItem.Image = Properties.Resources.Vision_Test_32;
            scheduleVisionTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(264, 38);
            scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            scheduleVisionTestToolStripMenuItem.Click += scheduleVisionTestToolStripMenuItem_Click;
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            scheduleWrittenTestToolStripMenuItem.Image = Properties.Resources.Written_Test_32;
            scheduleWrittenTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(264, 38);
            scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            scheduleWrittenTestToolStripMenuItem.Click += scheduleWrittenTestToolStripMenuItem_Click;
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            scheduleStreetTestToolStripMenuItem.Image = Properties.Resources.Street_Test_32;
            scheduleStreetTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(264, 38);
            scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            scheduleStreetTestToolStripMenuItem.Click += scheduleStreetTestToolStripMenuItem_Click;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.IssueDrivingLicense_32;
            issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(279, 38);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "&Issue Driving License";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = Properties.Resources.License_View_322;
            showLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(279, 38);
            showLicenseToolStripMenuItem.Text = "Show &License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_321;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(279, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Person &License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // frmListLocalDrivingLicesnseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 714);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dgvLocalDrivingLicenseApplications);
            Controls.Add(btnAddNewApplication);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmListLocalDrivingLicesnseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListLocalDrivingLicesnseApplications";
            Load += frmListLocalDrivingLicesnseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblTitle;
        private Label label1;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Button btnAddNewApplication;
        private DataGridView dgvLocalDrivingLicenseApplications;
        private Button btnClose;
        private Label label2;
        private Label lblRecordsCount;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private ToolStripMenuItem CancelApplicaitonToolStripMenuItem;
        private ToolStripMenuItem ScheduleTestsMenue;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}