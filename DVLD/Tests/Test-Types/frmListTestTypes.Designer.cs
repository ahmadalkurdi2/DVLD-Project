namespace DVLD.Tests.Test_Types
{
    partial class frmListTestTypes
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
            dgvTestTypes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editTestTypeToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            lblRecords = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TestType_512;
            pictureBox1.Location = new Point(406, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(298, 165);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(326, 45);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Manage Test Types";
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.ContextMenuStrip = contextMenuStrip1;
            dgvTestTypes.Location = new Point(12, 265);
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.Size = new Size(854, 140);
            dgvTestTypes.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editTestTypeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 42);
            // 
            // editTestTypeToolStripMenuItem
            // 
            editTestTypeToolStripMenuItem.Image = Properties.Resources.edit_322;
            editTestTypeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            editTestTypeToolStripMenuItem.Size = new Size(162, 38);
            editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            editTestTypeToolStripMenuItem.Click += editTestTypeToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(704, 427);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecords.Location = new Point(102, 433);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(34, 27);
            lblRecords.TabIndex = 16;
            lblRecords.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 433);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 15;
            label1.Text = "Records:";
            // 
            // frmListTestTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 485);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(dgvTestTypes);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "frmListTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListTestTypes";
            Load += frmListTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private DataGridView dgvTestTypes;
        private Button btnClose;
        private Label lblRecords;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}