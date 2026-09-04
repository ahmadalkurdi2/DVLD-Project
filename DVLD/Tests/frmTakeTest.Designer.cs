namespace DVLD.Tests
{
    partial class frmTakeTest
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
            ctrlScheduledTest1 = new DVLD.Tests.Controls.ctrlScheduledTest();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            rbPass = new RadioButton();
            rbFail = new RadioButton();
            lblUserMessage = new Label();
            label2 = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlScheduledTest1
            // 
            ctrlScheduledTest1.Location = new Point(26, -9);
            ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            ctrlScheduledTest1.Size = new Size(546, 681);
            ctrlScheduledTest1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(93, 678);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 685);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 29;
            label1.Text = "Result:";
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPass.Location = new Point(155, 685);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(58, 27);
            rbPass.TabIndex = 31;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFail.Location = new Point(219, 685);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(56, 27);
            rbFail.TabIndex = 32;
            rbFail.TabStop = true;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserMessage.ForeColor = Color.FromArgb(192, 0, 0);
            lblUserMessage.Location = new Point(307, 685);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(244, 23);
            lblUserMessage.TabIndex = 33;
            lblUserMessage.Text = "You cannot change the results";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 726);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 34;
            label2.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(134, 729);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(417, 92);
            txtNotes.TabIndex = 35;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(389, 853);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 40);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(220, 853);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(163, 40);
            btnClose.TabIndex = 51;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(90, 726);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 905);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(label2);
            Controls.Add(lblUserMessage);
            Controls.Add(rbFail);
            Controls.Add(rbPass);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(ctrlScheduledTest1);
            Name = "frmTakeTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTakeTest";
            Load += frmTakeTest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlScheduledTest ctrlScheduledTest1;
        private PictureBox pictureBox2;
        private Label label1;
        private RadioButton rbPass;
        private RadioButton rbFail;
        private Label lblUserMessage;
        private Label label2;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnClose;
        private PictureBox pictureBox1;
    }
}