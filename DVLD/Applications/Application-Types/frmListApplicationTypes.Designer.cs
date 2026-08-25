namespace DVLD.Applications.ApplicationTypes
{
    partial class frmListApplicationTypes
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
            dgvApplicationTypes = new DataGridView();
            cmsApplicationTypes = new ContextMenuStrip(components);
            editApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            cmsApplicationTypes.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(319, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(178, 190);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(422, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Manage Application Types";
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.ContextMenuStrip = cmsApplicationTypes;
            dgvApplicationTypes.Location = new Point(12, 258);
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.Size = new Size(776, 150);
            dgvApplicationTypes.TabIndex = 2;
            // 
            // cmsApplicationTypes
            // 
            cmsApplicationTypes.Items.AddRange(new ToolStripItem[] { editApplicationTypeToolStripMenuItem });
            cmsApplicationTypes.Name = "cmsApplicationTypes";
            cmsApplicationTypes.Size = new Size(187, 26);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            editApplicationTypeToolStripMenuItem.Size = new Size(186, 22);
            editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            editApplicationTypeToolStripMenuItem.Click += editApplicationTypeToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 439);
            label1.Name = "label1";
            label1.Size = new Size(67, 27);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(85, 439);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(45, 27);
            lblRecordsCount.TabIndex = 4;
            lblRecordsCount.Text = "???";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(626, 426);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmListApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label1);
            Controls.Add(dgvApplicationTypes);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "frmListApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListApplicationTypes";
            Load += frmListApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            cmsApplicationTypes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private DataGridView dgvApplicationTypes;
        private ContextMenuStrip cmsApplicationTypes;
        private ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private Label label1;
        private Label lblRecordsCount;
        private Button btnClose;
    }
}