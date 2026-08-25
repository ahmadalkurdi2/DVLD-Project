namespace DVLD.People
{
    partial class frmListPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPeople));
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pbPersonImage = new PictureBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            dgvPeople = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label2 = new Label();
            btnClose = new Button();
            lblTitle = new Label();
            btnAddPerson = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.People_400;
            pbPersonImage.Location = new Point(499, 30);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(204, 170);
            pbPersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonImage.TabIndex = 0;
            pbPersonImage.TabStop = false;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(352, 284);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(228, 23);
            cbFilterBy.TabIndex = 1;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BackColor = SystemColors.GradientActiveCaption;
            txtFilterValue.ForeColor = SystemColors.InfoText;
            txtFilterValue.Location = new Point(604, 284);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(187, 23);
            txtFilterValue.TabIndex = 2;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // dgvPeople
            // 
            dgvPeople.BackgroundColor = Color.White;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = contextMenuStrip1;
            dgvPeople.Location = new Point(63, 328);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.Size = new Size(989, 150);
            dgvPeople.TabIndex = 3;
            dgvPeople.DoubleClick += dgvPeople_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.AllowClickThrough = true;
            contextMenuStrip1.AllowDrop = true;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(179, 156);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showDetailsToolStripMenuItem.Image");
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(178, 38);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click_1;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.AddPerson_32;
            addNewPersonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(178, 38);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(178, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(178, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click_2;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(181, 515);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(45, 27);
            lblRecordsCount.TabIndex = 4;
            lblRecordsCount.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 515);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 5;
            label2.Text = "Records";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(890, 509);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(476, 214);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 45);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Manage People";
            // 
            // btnAddPerson
            // 
            btnAddPerson.Image = Properties.Resources.Add_Person_401;
            btnAddPerson.Location = new Point(977, 250);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(75, 57);
            btnAddPerson.TabIndex = 8;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click_1;
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 561);
            Controls.Add(btnAddPerson);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(lblRecordsCount);
            Controls.Add(dgvPeople);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(pbPersonImage);
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListPeople";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        public PictureBox pbPersonImage;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private DataGridView dgvPeople;
        private Label lblRecordsCount;
        private Label label2;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label lblTitle;
        private Button btnAddPerson;
    }
}