namespace DVLD.Licenses.Controls
{
    partial class ctrlDriverLicenses
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
            groupBox1 = new GroupBox();
            tcDriverLicenses = new TabControl();
            tpLocalLicenses = new TabPage();
            lblLocalLicensesRecords = new Label();
            label2 = new Label();
            dgvLocalLicensesHistory = new DataGridView();
            label1 = new Label();
            tbInternationalLicenses = new TabPage();
            lblInternationalLicensesRecords = new Label();
            label4 = new Label();
            dgvInternationalLicensesHistory = new DataGridView();
            label5 = new Label();
            groupBox1.SuspendLayout();
            tcDriverLicenses.SuspendLayout();
            tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).BeginInit();
            tbInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tcDriverLicenses);
            groupBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // tcDriverLicenses
            // 
            tcDriverLicenses.Controls.Add(tpLocalLicenses);
            tcDriverLicenses.Controls.Add(tbInternationalLicenses);
            tcDriverLicenses.Location = new Point(6, 29);
            tcDriverLicenses.Name = "tcDriverLicenses";
            tcDriverLicenses.SelectedIndex = 0;
            tcDriverLicenses.Size = new Size(835, 295);
            tcDriverLicenses.TabIndex = 0;
            // 
            // tpLocalLicenses
            // 
            tpLocalLicenses.Controls.Add(lblLocalLicensesRecords);
            tpLocalLicenses.Controls.Add(label2);
            tpLocalLicenses.Controls.Add(dgvLocalLicensesHistory);
            tpLocalLicenses.Controls.Add(label1);
            tpLocalLicenses.Location = new Point(4, 32);
            tpLocalLicenses.Name = "tpLocalLicenses";
            tpLocalLicenses.Padding = new Padding(3);
            tpLocalLicenses.Size = new Size(827, 259);
            tpLocalLicenses.TabIndex = 0;
            tpLocalLicenses.Text = "Local";
            tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblLocalLicensesRecords
            // 
            lblLocalLicensesRecords.AutoSize = true;
            lblLocalLicensesRecords.Location = new Point(83, 223);
            lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            lblLocalLicensesRecords.Size = new Size(37, 23);
            lblLocalLicensesRecords.TabIndex = 3;
            lblLocalLicensesRecords.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 223);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 2;
            label2.Text = "Records:";
            // 
            // dgvLocalLicensesHistory
            // 
            dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalLicensesHistory.Location = new Point(6, 39);
            dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            dgvLocalLicensesHistory.Size = new Size(815, 170);
            dgvLocalLicensesHistory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 0;
            label1.Text = "Local Licenses History:";
            // 
            // tbInternationalLicenses
            // 
            tbInternationalLicenses.Controls.Add(lblInternationalLicensesRecords);
            tbInternationalLicenses.Controls.Add(label4);
            tbInternationalLicenses.Controls.Add(dgvInternationalLicensesHistory);
            tbInternationalLicenses.Controls.Add(label5);
            tbInternationalLicenses.Location = new Point(4, 32);
            tbInternationalLicenses.Name = "tbInternationalLicenses";
            tbInternationalLicenses.Padding = new Padding(3);
            tbInternationalLicenses.Size = new Size(827, 259);
            tbInternationalLicenses.TabIndex = 1;
            tbInternationalLicenses.Text = "International";
            tbInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblInternationalLicensesRecords
            // 
            lblInternationalLicensesRecords.AutoSize = true;
            lblInternationalLicensesRecords.Location = new Point(84, 223);
            lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            lblInternationalLicensesRecords.Size = new Size(37, 23);
            lblInternationalLicensesRecords.TabIndex = 7;
            lblInternationalLicensesRecords.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 223);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 6;
            label4.Text = "Records:";
            // 
            // dgvInternationalLicensesHistory
            // 
            dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicensesHistory.Location = new Point(7, 39);
            dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            dgvInternationalLicensesHistory.Size = new Size(815, 170);
            dgvInternationalLicensesHistory.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 13);
            label5.Name = "label5";
            label5.Size = new Size(238, 23);
            label5.TabIndex = 4;
            label5.Text = "International Licenses History:";
            // 
            // ctrlDriverLicenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlDriverLicenses";
            Size = new Size(900, 362);
            groupBox1.ResumeLayout(false);
            tcDriverLicenses.ResumeLayout(false);
            tpLocalLicenses.ResumeLayout(false);
            tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).EndInit();
            tbInternationalLicenses.ResumeLayout(false);
            tbInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tcDriverLicenses;
        private TabPage tpLocalLicenses;
        private TabPage tbInternationalLicenses;
        private Label label1;
        private DataGridView dgvLocalLicensesHistory;
        private Label label2;
        private Label lblLocalLicensesRecords;
        private Label lblInternationalLicensesRecords;
        private Label label4;
        private DataGridView dgvInternationalLicensesHistory;
        private Label label5;
    }
}
