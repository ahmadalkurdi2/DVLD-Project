namespace DVLD.Applications.Release_Detained_License
{
    partial class frmListDetainedLicenses
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
            lblTitle = new Label();
            label1 = new Label();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            cbIsReleased = new ComboBox();
            btnReleaseDetainedLicense = new Button();
            btnDetainLicense = new Button();
            dgvDetainedLicenses = new DataGridView();
            cmsApplications = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            lblRecords = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).BeginInit();
            cmsApplications.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Detain_512;
            pictureBox1.Location = new Point(413, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(291, 137);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(371, 45);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "List Detained Licenses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 224);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 5;
            label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(104, 224);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(160, 23);
            cbFilterBy.TabIndex = 6;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(270, 224);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(158, 23);
            txtFilterValue.TabIndex = 7;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // cbIsReleased
            // 
            cbIsReleased.FormattingEnabled = true;
            cbIsReleased.Location = new Point(270, 224);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Size = new Size(108, 23);
            cbIsReleased.TabIndex = 8;
            cbIsReleased.SelectedIndexChanged += cbIsReleased_SelectedIndexChanged;
            // 
            // btnReleaseDetainedLicense
            // 
            btnReleaseDetainedLicense.Image = Properties.Resources.Release_Detained_License_64;
            btnReleaseDetainedLicense.Location = new Point(927, 204);
            btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            btnReleaseDetainedLicense.Size = new Size(75, 66);
            btnReleaseDetainedLicense.TabIndex = 10;
            btnReleaseDetainedLicense.UseVisualStyleBackColor = true;
            btnReleaseDetainedLicense.Click += btnReleaseDetainedLicense_Click;
            // 
            // btnDetainLicense
            // 
            btnDetainLicense.Image = Properties.Resources.Detain_642;
            btnDetainLicense.Location = new Point(1008, 204);
            btnDetainLicense.Name = "btnDetainLicense";
            btnDetainLicense.Size = new Size(75, 66);
            btnDetainLicense.TabIndex = 11;
            btnDetainLicense.UseVisualStyleBackColor = true;
            btnDetainLicense.Click += btnDetainLicense_Click;
            // 
            // dgvDetainedLicenses
            // 
            dgvDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetainedLicenses.ContextMenuStrip = cmsApplications;
            dgvDetainedLicenses.Location = new Point(12, 295);
            dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            dgvDetainedLicenses.Size = new Size(1071, 249);
            dgvDetainedLicenses.TabIndex = 12;
            // 
            // cmsApplications
            // 
            cmsApplications.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmsApplications.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            cmsApplications.Name = "cmsApplications";
            cmsApplications.Size = new Size(306, 156);
            cmsApplications.Opening += cmsApplications_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(305, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(305, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(305, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = Properties.Resources.Release_Detained_License_32;
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(305, 38);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 568);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 13;
            label2.Text = "Records:";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(95, 568);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(37, 23);
            lblRecords.TabIndex = 14;
            lblRecords.Text = "???";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(932, 559);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(151, 40);
            btnClose.TabIndex = 50;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmListDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 608);
            Controls.Add(btnClose);
            Controls.Add(lblRecords);
            Controls.Add(label2);
            Controls.Add(dgvDetainedLicenses);
            Controls.Add(btnDetainLicense);
            Controls.Add(btnReleaseDetainedLicense);
            Controls.Add(cbIsReleased);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "frmListDetainedLicenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListDetainedLicenses";
            Load += frmListDetainedLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).EndInit();
            cmsApplications.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label label1;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private ComboBox cbIsReleased;
        private Button btnReleaseDetainedLicense;
        private Button btnDetainLicense;
        private DataGridView dgvDetainedLicenses;
        private Label label2;
        private Label lblRecords;
        private Button btnClose;
        private ContextMenuStrip cmsApplications;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}