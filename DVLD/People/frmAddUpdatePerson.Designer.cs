namespace DVLD.People
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            lblTitle = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            lblPersonID = new Label();
            groupBox1 = new GroupBox();
            btnSave1 = new Button();
            btnClose = new Button();
            llRemoveImage = new LinkLabel();
            llSetImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            cbCountry = new ComboBox();
            pictureBox10 = new PictureBox();
            label13 = new Label();
            pictureBox9 = new PictureBox();
            txtPhone = new TextBox();
            label12 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            pictureBox8 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtLastName = new TextBox();
            txtThirdName = new TextBox();
            txtSecondName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtNationalNo = new TextBox();
            txtFirstName = new TextBox();
            rbFemale = new RadioButton();
            pictureBox7 = new PictureBox();
            rbMale = new RadioButton();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(375, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 45);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Add New Person";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 107);
            label3.Name = "label3";
            label3.Size = new Size(103, 27);
            label3.TabIndex = 11;
            label3.Text = "Person ID";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(146, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(198, 107);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(51, 27);
            lblPersonID.TabIndex = 13;
            lblPersonID.Text = "N/A";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave1);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(llRemoveImage);
            groupBox1.Controls.Add(llSetImage);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Controls.Add(cbCountry);
            groupBox1.Controls.Add(pictureBox10);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtThirdName);
            groupBox1.Controls.Add(txtSecondName);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNationalNo);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(931, 529);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnSave1
            // 
            btnSave1.BackColor = Color.Green;
            btnSave1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave1.ForeColor = Color.White;
            btnSave1.ImageAlign = ContentAlignment.MiddleRight;
            btnSave1.Location = new Point(636, 451);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(128, 40);
            btnSave1.TabIndex = 49;
            btnSave1.Text = "Save";
            btnSave1.UseVisualStyleBackColor = false;
            btnSave1.Click += btnSave1_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(498, 451);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 40);
            btnClose.TabIndex = 48;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnSave_Click;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llRemoveImage.LinkBehavior = LinkBehavior.NeverUnderline;
            llRemoveImage.LinkColor = Color.Purple;
            llRemoveImage.Location = new Point(717, 359);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(80, 27);
            llRemoveImage.TabIndex = 46;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llSetImage.LinkBehavior = LinkBehavior.NeverUnderline;
            llSetImage.LinkColor = Color.Purple;
            llSetImage.Location = new Point(701, 326);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(110, 27);
            llSetImage.TabIndex = 45;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.Male_512;
            pbPersonImage.Location = new Point(701, 201);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(117, 106);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 44;
            pbPersonImage.TabStop = false;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(675, 156);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(200, 23);
            cbCountry.TabIndex = 43;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Country_32;
            pictureBox10.Location = new Point(637, 151);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(32, 32);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 42;
            pictureBox10.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(467, 152);
            label13.Name = "label13";
            label13.Size = new Size(91, 27);
            label13.TabIndex = 41;
            label13.Text = "Country:";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Phone_32;
            pictureBox9.Location = new Point(636, 109);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 32);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 40;
            pictureBox9.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(675, 118);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 39;
            txtPhone.Validating += ValidateEmptyTextBox;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(461, 118);
            label12.Name = "label12";
            label12.Size = new Size(72, 27);
            label12.TabIndex = 38;
            label12.Text = "Phone:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(675, 79);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 37;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Calendar_32;
            pictureBox8.Location = new Point(633, 75);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 32);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 36;
            pictureBox8.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(461, 79);
            label11.Name = "label11";
            label11.Size = new Size(152, 27);
            label11.TabIndex = 34;
            label11.Text = "Date Of Birth:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(662, 11);
            label10.Name = "label10";
            label10.Size = new Size(51, 27);
            label10.TabIndex = 33;
            label10.Text = "Last";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(526, 11);
            label9.Name = "label9";
            label9.Size = new Size(61, 27);
            label9.TabIndex = 32;
            label9.Text = "Third";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(373, 9);
            label8.Name = "label8";
            label8.Size = new Size(77, 27);
            label8.TabIndex = 31;
            label8.Text = "Second";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(252, 9);
            label7.Name = "label7";
            label7.Size = new Size(56, 27);
            label7.TabIndex = 15;
            label7.Text = "First";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(633, 41);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(115, 23);
            txtLastName.TabIndex = 30;
            txtLastName.Validating += ValidateEmptyTextBox;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(498, 41);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(115, 23);
            txtThirdName.TabIndex = 29;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(358, 39);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(115, 23);
            txtSecondName.TabIndex = 28;
            txtSecondName.Validating += ValidateEmptyTextBox;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(222, 196);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(443, 190);
            txtAddress.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(222, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(115, 23);
            txtEmail.TabIndex = 26;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtNationalNo
            // 
            txtNationalNo.Location = new Point(222, 75);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(115, 23);
            txtNationalNo.TabIndex = 25;
            txtNationalNo.Validating += txtNationalNo_Validating;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(222, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(115, 23);
            txtFirstName.TabIndex = 24;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(305, 119);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 23;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Woman_32;
            pictureBox7.Location = new Point(267, 109);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(199, 119);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 21;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Address_32;
            pictureBox6.Location = new Point(161, 196);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(161, 151);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Man_32;
            pictureBox4.Location = new Point(161, 109);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(161, 70);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Person_32;
            pictureBox1.Location = new Point(161, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 201);
            label6.Name = "label6";
            label6.Size = new Size(94, 27);
            label6.TabIndex = 16;
            label6.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 156);
            label5.Name = "label5";
            label5.Size = new Size(68, 27);
            label5.TabIndex = 15;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(85, 27);
            label4.TabIndex = 14;
            label4.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(72, 27);
            label2.TabIndex = 13;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 75);
            label1.Name = "label1";
            label1.Size = new Size(129, 27);
            label1.TabIndex = 12;
            label1.Text = "National No:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 684);
            Controls.Add(groupBox1);
            Controls.Add(lblPersonID);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Name = "frmAddUpdatePerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdatePerson";
            Load += frmAddUpdatePerson_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label3;
        private PictureBox pictureBox2;
        private Label lblPersonID;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private RadioButton rbFemale;
        private PictureBox pictureBox7;
        private RadioButton rbMale;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtNationalNo;
        private TextBox txtFirstName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtLastName;
        private TextBox txtThirdName;
        private TextBox txtSecondName;
        private PictureBox pictureBox10;
        private Label label13;
        private PictureBox pictureBox9;
        private TextBox txtPhone;
        private Label label12;
        private DateTimePicker dtpDateOfBirth;
        private PictureBox pictureBox8;
        private Label label11;
        private ComboBox cbCountry;
        private PictureBox pbPersonImage;
        private LinkLabel llSetImage;
        private LinkLabel llRemoveImage;
        private Button btnSave1;
        private Button btnClose;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}