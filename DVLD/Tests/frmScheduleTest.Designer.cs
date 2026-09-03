namespace DVLD.Tests.Test_Types
{
    partial class frmScheduleTest
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
            ctrlScheduleTest1 = new ctrlScheduleTest();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.AutoScroll = true;
            ctrlScheduleTest1.Location = new Point(12, 12);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new Size(857, 747);
            ctrlScheduleTest1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(484, 670);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(163, 40);
            btnClose.TabIndex = 49;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmScheduleTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 749);
            Controls.Add(btnClose);
            Controls.Add(ctrlScheduleTest1);
            Name = "frmScheduleTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmScheduleTest";
            Load += frmScheduleTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlScheduleTest ctrlScheduleTest1;
        private Button btnClose;
    }
}