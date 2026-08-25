namespace DVLD.User
{
    partial class frmListUsers
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
            cbIsActive = new ComboBox();
            txtFilterValue = new TextBox();
            dgvUsers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            btnAddUser = new Button();
            label2 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users_2_400;
            pictureBox1.Location = new Point(490, 37);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(464, 247);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 45);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Manage Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 324);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 10;
            label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(361, 321);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(252, 31);
            cbFilterBy.TabIndex = 11;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // cbIsActive
            // 
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Location = new Point(628, 321);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(186, 31);
            cbIsActive.TabIndex = 12;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(628, 322);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(252, 30);
            txtFilterValue.TabIndex = 13;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStrip1;
            dgvUsers.Location = new Point(12, 403);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(1148, 150);
            dgvUsers.TabIndex = 14;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.CellContentDoubleClick += dgvUsers_CellContentDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewUserToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 194);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(184, 38);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Image = Properties.Resources.Add_New_User_32;
            addNewUserToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(184, 38);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_321;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(184, 38);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_321;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(184, 38);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_321;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(184, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Image = Properties.Resources.Add_New_User_72;
            btnAddUser.Location = new Point(940, 292);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(90, 86);
            btnAddUser.TabIndex = 15;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 583);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 16;
            label2.Text = "Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(92, 583);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(37, 23);
            lblRecordsCount.TabIndex = 17;
            lblRecordsCount.Text = "???";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(1032, 574);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 40);
            btnClose.TabIndex = 51;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmListUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1172, 621);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(btnAddUser);
            Controls.Add(dgvUsers);
            Controls.Add(txtFilterValue);
            Controls.Add(cbIsActive);
            Controls.Add(cbFilterBy);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListUsers";
            Load += frmListUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label label1;
        private ComboBox cbFilterBy;
        private ComboBox cbIsActive;
        private TextBox txtFilterValue;
        private DataGridView dgvUsers;
        private Button btnAddUser;
        private Label label2;
        private Label lblRecordsCount;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}