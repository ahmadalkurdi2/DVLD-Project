namespace DVLD.User
{
    partial class frmAddUpdateUser
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
            tcUserInfo = new TabControl();
            tpPersonalInfo = new TabPage();
            btnPersonInfoNext = new Button();
            ctrlPersonCardWithFilter1 = new DVLD.People.Controls.ctrlPersonCardWithFilter();
            tpLoginInfo = new TabPage();
            chkIsActive = new CheckBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblUserID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTitle = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tcUserInfo.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tcUserInfo
            // 
            tcUserInfo.Controls.Add(tpPersonalInfo);
            tcUserInfo.Controls.Add(tpLoginInfo);
            tcUserInfo.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tcUserInfo.Location = new Point(12, 84);
            tcUserInfo.Name = "tcUserInfo";
            tcUserInfo.SelectedIndex = 0;
            tcUserInfo.Size = new Size(1046, 568);
            tcUserInfo.TabIndex = 0;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.Controls.Add(btnPersonInfoNext);
            tpPersonalInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonalInfo.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpPersonalInfo.Location = new Point(4, 32);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(3);
            tpPersonalInfo.Size = new Size(1038, 532);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "Personal Info";
            tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnPersonInfoNext
            // 
            btnPersonInfoNext.BackColor = Color.FromArgb(0, 0, 192);
            btnPersonInfoNext.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPersonInfoNext.ForeColor = Color.White;
            btnPersonInfoNext.ImageAlign = ContentAlignment.MiddleRight;
            btnPersonInfoNext.Location = new Point(808, 470);
            btnPersonInfoNext.Name = "btnPersonInfoNext";
            btnPersonInfoNext.Size = new Size(162, 40);
            btnPersonInfoNext.TabIndex = 8;
            btnPersonInfoNext.Text = "Next";
            btnPersonInfoNext.UseVisualStyleBackColor = false;
            btnPersonInfoNext.Click += btnPersonInfoNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.Location = new Point(31, -14);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(1073, 468);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.AutoScroll = true;
            tpLoginInfo.Controls.Add(chkIsActive);
            tpLoginInfo.Controls.Add(txtConfirmPassword);
            tpLoginInfo.Controls.Add(txtPassword);
            tpLoginInfo.Controls.Add(txtUserName);
            tpLoginInfo.Controls.Add(lblUserID);
            tpLoginInfo.Controls.Add(label4);
            tpLoginInfo.Controls.Add(label3);
            tpLoginInfo.Controls.Add(label2);
            tpLoginInfo.Controls.Add(label1);
            tpLoginInfo.Location = new Point(4, 32);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(3);
            tpLoginInfo.Size = new Size(1038, 532);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "Login Info";
            tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(331, 212);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(102, 27);
            chkIsActive.TabIndex = 8;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(299, 149);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(187, 30);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(299, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 30);
            txtPassword.TabIndex = 6;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(299, 64);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(187, 30);
            txtUserName.TabIndex = 5;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(299, 25);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(37, 23);
            lblUserID.TabIndex = 4;
            lblUserID.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 156);
            label4.Name = "label4";
            label4.Size = new Size(145, 23);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(344, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(353, 45);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Edit Application Type";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(930, 676);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 40);
            btnSave.TabIndex = 51;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(796, 676);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 40);
            btnClose.TabIndex = 50;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1093, 728);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(tcUserInfo);
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateUser";
            WindowState = FormWindowState.Maximized;
            Activated += frmAddUpdateUser_Activated;
            Load += frmAddUpdateUser_Load;
            tcUserInfo.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tcUserInfo;
        private TabPage tpPersonalInfo;
        private TabPage tpLoginInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Button btnPersonInfoNext;
        private Label lblTitle;
        private Button btnSave;
        private Button btnClose;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblUserID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkIsActive;
        private ErrorProvider errorProvider1;
    }
}