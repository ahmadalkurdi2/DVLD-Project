namespace DVLD.Applications.International_License
{
    partial class frmListInternationalLicesnseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListInternationalLicesnseApplications));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTitle = new Label();
            cbFilterBy = new ComboBox();
            cbIsReleased = new ComboBox();
            txtFilterValue = new TextBox();
            btnNewApplication = new Button();
            dgvInternationalLicenses = new DataGridView();
            btnClose = new Button();
            lblInternationalLicensesRecords = new Label();
            label1 = new Label();
            cmsApplications = new ContextMenuStrip(components);
            PesonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            cmsApplications.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(507, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.International_322;
            pictureBox2.Location = new Point(611, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(283, 176);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(545, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "International License Applications";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "International License ID", "Application ID", "Driver ID", "Local License ID", "Is Active" });
            cbFilterBy.Location = new Point(253, 297);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(121, 23);
            cbFilterBy.TabIndex = 4;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // cbIsReleased
            // 
            cbIsReleased.FormattingEnabled = true;
            cbIsReleased.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsReleased.Location = new Point(380, 297);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Size = new Size(90, 23);
            cbIsReleased.TabIndex = 5;
            cbIsReleased.SelectedIndexChanged += cbIsReleased_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(380, 297);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(162, 23);
            txtFilterValue.TabIndex = 6;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // btnNewApplication
            // 
            btnNewApplication.Image = (Image)resources.GetObject("btnNewApplication.Image");
            btnNewApplication.Location = new Point(913, 239);
            btnNewApplication.Name = "btnNewApplication";
            btnNewApplication.Size = new Size(93, 81);
            btnNewApplication.TabIndex = 7;
            btnNewApplication.UseVisualStyleBackColor = true;
            btnNewApplication.Click += btnNewApplication_Click;
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.ContextMenuStrip = cmsApplications;
            dgvInternationalLicenses.Location = new Point(12, 365);
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.Size = new Size(994, 253);
            dgvInternationalLicenses.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(844, 643);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblInternationalLicensesRecords
            // 
            lblInternationalLicensesRecords.AutoSize = true;
            lblInternationalLicensesRecords.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInternationalLicensesRecords.Location = new Point(85, 649);
            lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            lblInternationalLicensesRecords.Size = new Size(45, 27);
            lblInternationalLicensesRecords.TabIndex = 10;
            lblInternationalLicensesRecords.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 649);
            label1.Name = "label1";
            label1.Size = new Size(67, 27);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // cmsApplications
            // 
            cmsApplications.Items.AddRange(new ToolStripItem[] { PesonDetailsToolStripMenuItem, showDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cmsApplications.Name = "cmsApplications";
            cmsApplications.Size = new Size(242, 118);
            // 
            // PesonDetailsToolStripMenuItem
            // 
            PesonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            PesonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
            PesonDetailsToolStripMenuItem.Size = new Size(241, 38);
            PesonDetailsToolStripMenuItem.Text = "Show Person Details";
            PesonDetailsToolStripMenuItem.Click += PesonDetailsToolStripMenuItem_Click;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(241, 38);
            showDetailsToolStripMenuItem.Text = "Show License Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(241, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // frmListInternationalLicesnseApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 696);
            Controls.Add(btnClose);
            Controls.Add(lblInternationalLicensesRecords);
            Controls.Add(label1);
            Controls.Add(dgvInternationalLicenses);
            Controls.Add(btnNewApplication);
            Controls.Add(txtFilterValue);
            Controls.Add(cbIsReleased);
            Controls.Add(cbFilterBy);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmListInternationalLicesnseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListInternationalLicesnseApplications";
            Load += frmListInternationalLicesnseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            cmsApplications.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblTitle;
        private ComboBox cbFilterBy;
        private ComboBox cbIsReleased;
        private TextBox txtFilterValue;
        private Button btnNewApplication;
        private DataGridView dgvInternationalLicenses;
        private Button btnClose;
        private Label lblInternationalLicensesRecords;
        private Label label1;
        private ContextMenuStrip cmsApplications;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem PesonDetailsToolStripMenuItem;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}