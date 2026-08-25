namespace DVLD.NewFolder
{
    partial class frmLogin
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
            splitContainer1 = new SplitContainer();
            btnLoginClose = new Button();
            btnLogin = new Button();
            chkRememberMe = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Left;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = Properties.Resources.DVLD_Login_Background_2;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(99, 139, 158);
            splitContainer1.Panel2.Controls.Add(btnLoginClose);
            splitContainer1.Panel2.Controls.Add(btnLogin);
            splitContainer1.Panel2.Controls.Add(chkRememberMe);
            splitContainer1.Panel2.Controls.Add(txtPassword);
            splitContainer1.Panel2.Controls.Add(txtUserName);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(pictureBox7);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(932, 483);
            splitContainer1.SplitterDistance = 377;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // btnLoginClose
            // 
            btnLoginClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoginClose.BackColor = Color.Transparent;
            btnLoginClose.Cursor = Cursors.Hand;
            btnLoginClose.DialogResult = DialogResult.Cancel;
            btnLoginClose.FlatAppearance.BorderColor = Color.White;
            btnLoginClose.FlatAppearance.BorderSize = 0;
            btnLoginClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLoginClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoginClose.FlatStyle = FlatStyle.Flat;
            btnLoginClose.ForeColor = SystemColors.ActiveBorder;
            btnLoginClose.Image = Properties.Resources.closeBlack32;
            btnLoginClose.Location = new Point(503, 12);
            btnLoginClose.Name = "btnLoginClose";
            btnLoginClose.Size = new Size(35, 34);
            btnLoginClose.TabIndex = 30;
            btnLoginClose.UseVisualStyleBackColor = false;
            btnLoginClose.Click += btnLoginClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(114, 175, 143);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(335, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(156, 49);
            btnLogin.TabIndex = 29;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = Color.White;
            chkRememberMe.Location = new Point(335, 262);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(162, 31);
            chkRememberMe.TabIndex = 28;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(246, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 30);
            txtPassword.TabIndex = 27;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(246, 168);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(245, 30);
            txtUserName.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Person_32;
            pictureBox1.Location = new Point(179, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.Number_32;
            pictureBox7.Location = new Point(179, 213);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 211);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 166);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 1;
            label2.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 84);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 0;
            label1.Text = "Login to your account";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 483);
            Controls.Add(splitContainer1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private CheckBox chkRememberMe;
        private Button btnLogin;
        private Button btnLoginClose;
    }
}