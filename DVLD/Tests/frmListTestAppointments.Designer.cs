namespace DVLD.Tests
{
    partial class frmListTestAppointments
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
            pbTestTypeImage = new PictureBox();
            lblTitle = new Label();
            ctrlDrivingLicenseApplicationInfo1 = new DVLD.Applications.ctrlDrivingLicenseApplicationInfo();
            label1 = new Label();
            dgvLicenseTestAppointments = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            btnClose = new Button();
            btnAddNewAppointment = new Button();
            lblRecordsCount = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.Image = Properties.Resources.Vision_Test_32;
            pbTestTypeImage.Location = new Point(499, 14);
            pbTestTypeImage.Margin = new Padding(4, 5, 4, 5);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(139, 109);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTestTypeImage.TabIndex = 2;
            pbTestTypeImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(461, 176);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(399, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Vision Test Appointment";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(13, 130);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(1103, 449);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(800, 398);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 5;
            label1.Text = "Appointments";
            // 
            // dgvLicenseTestAppointments
            // 
            dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicenseTestAppointments.ContextMenuStrip = contextMenuStrip1;
            dgvLicenseTestAppointments.Location = new Point(26, 587);
            dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            dgvLicenseTestAppointments.Size = new Size(1090, 150);
            dgvLicenseTestAppointments.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 80);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(138, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = Properties.Resources.Test_32;
            takeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(138, 38);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(800, 455);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 8;
            label2.Text = "Records:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(936, 526);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(163, 40);
            btnClose.TabIndex = 50;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewAppointment
            // 
            btnAddNewAppointment.FlatStyle = FlatStyle.Flat;
            btnAddNewAppointment.Image = Properties.Resources.AddAppointment_32;
            btnAddNewAppointment.Location = new Point(1041, 386);
            btnAddNewAppointment.Name = "btnAddNewAppointment";
            btnAddNewAppointment.Size = new Size(58, 43);
            btnAddNewAppointment.TabIndex = 51;
            btnAddNewAppointment.UseVisualStyleBackColor = true;
            btnAddNewAppointment.Click += btnAddNewAppointment_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(1041, 455);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(37, 23);
            lblRecordsCount.TabIndex = 52;
            lblRecordsCount.Text = "???";
            // 
            // frmListTestAppointments
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 749);
            Controls.Add(lblRecordsCount);
            Controls.Add(btnAddNewAppointment);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(dgvLicenseTestAppointments);
            Controls.Add(label1);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Controls.Add(lblTitle);
            Controls.Add(pbTestTypeImage);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListTestAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListTestAppointments";
            Load += frmListTestAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbTestTypeImage;
        private Label lblTitle;
        private Applications.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnClose;
        private Button btnAddNewAppointment;
        private DataGridView dgvLicenseTestAppointments;
        private Label lblRecordsCount;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}