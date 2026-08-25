namespace DVLD.User
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            groupBox1 = new GroupBox();
            label1 = new Label();
            lblUserID = new Label();
            label3 = new Label();
            lblUserName = new Label();
            label5 = new Label();
            lblIsActive = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(77, 0);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(930, 362);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(90, 384);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(902, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(142, 44);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(37, 23);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 47);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "UserName:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(431, 47);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(37, 23);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "???";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(613, 47);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 4;
            label5.Text = "Is Active:";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(703, 47);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(37, 23);
            lblIsActive.TabIndex = 5;
            lblIsActive.Text = "???";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserCard";
            Size = new Size(1090, 522);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox groupBox1;
        private Label lblIsActive;
        private Label label5;
        private Label lblUserName;
        private Label label3;
        private Label lblUserID;
        private Label label1;
    }
}
