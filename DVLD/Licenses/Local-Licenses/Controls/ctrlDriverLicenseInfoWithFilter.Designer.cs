namespace DVLD.Licenses.Local_Licenses.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            components = new System.ComponentModel.Container();
            gbFilters = new GroupBox();
            btnFind = new Button();
            txtLicenseID = new TextBox();
            label1 = new Label();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            errorProvider1 = new ErrorProvider(components);
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(txtLicenseID);
            gbFilters.Controls.Add(label1);
            gbFilters.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilters.Location = new Point(13, 3);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(734, 81);
            gbFilters.TabIndex = 0;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.White;
            btnFind.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.Image = Properties.Resources.License_View_32;
            btnFind.ImageAlign = ContentAlignment.MiddleRight;
            btnFind.Location = new Point(461, 21);
            btnFind.Name = "btnFind";
            btnFind.Padding = new Padding(0, 0, 14, 0);
            btnFind.Size = new Size(167, 48);
            btnFind.TabIndex = 2;
            btnFind.Text = "Search";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtLicenseID
            // 
            txtLicenseID.Location = new Point(158, 32);
            txtLicenseID.Name = "txtLicenseID";
            txtLicenseID.Size = new Size(288, 30);
            txtLicenseID.TabIndex = 1;
            txtLicenseID.KeyPress += txtLicenseID_KeyPress;
            txtLicenseID.Validating += txtLicenseID_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(118, 27);
            label1.TabIndex = 0;
            label1.Text = "License ID:";
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Location = new Point(-11, 95);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1222, 341);
            ctrlDriverLicenseInfo1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlDriverLicenseInfo1);
            Controls.Add(gbFilters);
            Name = "ctrlDriverLicenseInfoWithFilter";
            Size = new Size(1251, 436);
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFilters;
        private TextBox txtLicenseID;
        private Label label1;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private ErrorProvider errorProvider1;
        private Button btnFind;
    }
}
