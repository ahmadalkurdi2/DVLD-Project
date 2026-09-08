namespace DVLD.Drivers
{
    partial class frmListDrivers
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
            dgvDrivers = new DataGridView();
            cmsDrivers = new ContextMenuStrip(components);
            ShowPersonInfoToolStripMenuItem = new ToolStripMenuItem();
            ShowPersonLicenseHistoryToolMenuStripItem = new ToolStripMenuItem();
            label2 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            cmsDrivers.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Driver_Main;
            pictureBox1.Location = new Point(270, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(221, 177);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Manage Drivers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 299);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 6;
            label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(120, 305);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(239, 23);
            cbFilterBy.TabIndex = 7;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(389, 305);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(283, 23);
            txtFilterValue.TabIndex = 12;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // dgvDrivers
            // 
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.ContextMenuStrip = cmsDrivers;
            dgvDrivers.Location = new Point(12, 375);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.Size = new Size(660, 150);
            dgvDrivers.TabIndex = 13;
            // 
            // cmsDrivers
            // 
            cmsDrivers.Items.AddRange(new ToolStripItem[] { ShowPersonInfoToolStripMenuItem, ShowPersonLicenseHistoryToolMenuStripItem });
            cmsDrivers.Name = "cmsDrivers";
            cmsDrivers.Size = new Size(303, 80);
            // 
            // ShowPersonInfoToolStripMenuItem
            // 
            ShowPersonInfoToolStripMenuItem.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPersonInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            ShowPersonInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowPersonInfoToolStripMenuItem.Name = "ShowPersonInfoToolStripMenuItem";
            ShowPersonInfoToolStripMenuItem.Size = new Size(302, 38);
            ShowPersonInfoToolStripMenuItem.Text = "Show Person Info";
            ShowPersonInfoToolStripMenuItem.Click += ShowPersonInfoToolStripMenuItem_Click;
            // 
            // ShowPersonLicenseHistoryToolMenuStripItem
            // 
            ShowPersonLicenseHistoryToolMenuStripItem.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPersonLicenseHistoryToolMenuStripItem.Image = Properties.Resources.PersonLicenseHistory_32;
            ShowPersonLicenseHistoryToolMenuStripItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowPersonLicenseHistoryToolMenuStripItem.Name = "ShowPersonLicenseHistoryToolMenuStripItem";
            ShowPersonLicenseHistoryToolMenuStripItem.Size = new Size(302, 38);
            ShowPersonLicenseHistoryToolMenuStripItem.Text = "Show Person License History";
            ShowPersonLicenseHistoryToolMenuStripItem.Click += ShowPersonLicenseHistoryToolMenuStripItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 560);
            label2.Name = "label2";
            label2.Size = new Size(92, 27);
            label2.TabIndex = 14;
            label2.Text = "Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(110, 560);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(45, 27);
            lblRecordsCount.TabIndex = 15;
            lblRecordsCount.Text = "???";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(510, 554);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmListDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 621);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvDrivers);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "frmListDrivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListDrivers";
            Load += frmListDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            cmsDrivers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label label1;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private DataGridView dgvDrivers;
        private Label label2;
        private Label lblRecordsCount;
        private Button btnClose;
        private ContextMenuStrip cmsDrivers;
        private ToolStripMenuItem ShowPersonLicenseHistoryToolMenuStripItem;
        private ToolStripMenuItem ShowPersonInfoToolStripMenuItem;
    }
}