namespace DVLD.Applications.ApplicationTypes
{
    partial class frmEditApplicationType
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
            lblApplicationTypeID = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtFees = new TextBox();
            btnClose = new Button();
            button1 = new Button();
            txtTitle = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(200, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(417, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Update Application Types";
            // 
            // lblApplicationTypeID
            // 
            lblApplicationTypeID.AutoSize = true;
            lblApplicationTypeID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationTypeID.Location = new Point(225, 158);
            lblApplicationTypeID.Name = "lblApplicationTypeID";
            lblApplicationTypeID.Size = new Size(34, 27);
            lblApplicationTypeID.TabIndex = 6;
            lblApplicationTypeID.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 158);
            label1.Name = "label1";
            label1.Size = new Size(36, 27);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 283);
            label2.Name = "label2";
            label2.Size = new Size(55, 27);
            label2.TabIndex = 7;
            label2.Text = "Fees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 213);
            label3.Name = "label3";
            label3.Size = new Size(55, 27);
            label3.TabIndex = 8;
            label3.Text = "Title";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ApplicationTitle;
            pictureBox1.Location = new Point(245, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(245, 278);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // txtFees
            // 
            txtFees.Location = new Point(343, 283);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(274, 23);
            txtFees.TabIndex = 12;
            txtFees.Validating += txtFees_Validating;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(455, 381);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 40);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(287, 381);
            button1.Name = "button1";
            button1.Size = new Size(162, 40);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(343, 213);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(274, 23);
            txtTitle.TabIndex = 11;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmEditApplicationType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnClose);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblApplicationTypeID);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "frmEditApplicationType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditApplicationType";
            Load += frmEditApplicationType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblApplicationTypeID;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtFees;
        private Button btnClose;
        private Button button1;
        private TextBox txtTitle;
        private ErrorProvider errorProvider;
    }
}