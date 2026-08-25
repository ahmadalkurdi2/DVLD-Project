namespace DVLD.Tests.Test_Types
{
    partial class frmEditTestType
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
            lblTitle = new Label();
            label1 = new Label();
            lblTestTypeID = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtFees = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            btnClose = new Button();
            btnSave1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(264, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(305, 45);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Update Test Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 124);
            label1.Name = "label1";
            label1.Size = new Size(44, 27);
            label1.TabIndex = 16;
            label1.Text = "ID:";
            // 
            // lblTestTypeID
            // 
            lblTestTypeID.AutoSize = true;
            lblTestTypeID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypeID.Location = new Point(209, 124);
            lblTestTypeID.Name = "lblTestTypeID";
            lblTestTypeID.Size = new Size(45, 27);
            lblTestTypeID.TabIndex = 17;
            lblTestTypeID.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 170);
            label2.Name = "label2";
            label2.Size = new Size(63, 27);
            label2.TabIndex = 18;
            label2.Text = "Title:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ApplicationTitle1;
            pictureBox3.Location = new Point(209, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(264, 176);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(403, 23);
            txtTitle.TabIndex = 20;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(264, 210);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(403, 113);
            txtDescription.TabIndex = 23;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ApplicationTitle1;
            pictureBox1.Location = new Point(209, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 220);
            label3.Name = "label3";
            label3.Size = new Size(122, 27);
            label3.TabIndex = 21;
            label3.Text = "Description:";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(264, 334);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(403, 23);
            txtFees.TabIndex = 26;
            txtFees.Validating += txtFees_Validating;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(209, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 328);
            label4.Name = "label4";
            label4.Size = new Size(63, 27);
            label4.TabIndex = 24;
            label4.Text = "Fees:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(337, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave1
            // 
            btnSave1.BackColor = Color.Green;
            btnSave1.FlatStyle = FlatStyle.Flat;
            btnSave1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave1.ForeColor = Color.White;
            btnSave1.ImageAlign = ContentAlignment.MiddleRight;
            btnSave1.Location = new Point(505, 406);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(162, 40);
            btnSave1.TabIndex = 50;
            btnSave1.Text = "Save";
            btnSave1.UseVisualStyleBackColor = false;
            btnSave1.Click += btnSave1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditTestType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(btnSave1);
            Controls.Add(btnClose);
            Controls.Add(txtFees);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(lblTestTypeID);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "frmEditTestType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditTestType";
            Load += frmEditTestType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblTestTypeID;
        private Label label2;
        private PictureBox pictureBox3;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtFees;
        private PictureBox pictureBox2;
        private Label label4;
        private Button btnClose;
        private Button btnSave1;
        private ErrorProvider errorProvider1;
    }
}