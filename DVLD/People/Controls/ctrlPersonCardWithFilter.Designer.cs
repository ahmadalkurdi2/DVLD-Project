namespace DVLD.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            gbFilters = new GroupBox();
            btnAddNewPerson = new Button();
            btnFind = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            ctrlPersonCard2 = new ctrlPersonCard();
            errorProvider1 = new ErrorProvider(components);
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnAddNewPerson);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(cbFilterBy);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilters.Location = new Point(19, 24);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(923, 75);
            gbFilters.TabIndex = 0;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.Image = (Image)resources.GetObject("btnAddNewPerson.Image");
            btnAddNewPerson.Location = new Point(871, 27);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(40, 39);
            btnAddNewPerson.TabIndex = 9;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnFind
            // 
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.Location = new Point(825, 27);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(40, 39);
            btnFind.TabIndex = 8;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Location = new Point(121, 27);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(297, 34);
            cbFilterBy.TabIndex = 2;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(446, 27);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(324, 34);
            txtFilterValue.TabIndex = 1;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 26);
            label1.TabIndex = 0;
            label1.Text = "Find By:";
            // 
            // ctrlPersonCard2
            // 
            ctrlPersonCard2.Location = new Point(19, 106);
            ctrlPersonCard2.Name = "ctrlPersonCard2";
            ctrlPersonCard2.Size = new Size(973, 383);
            ctrlPersonCard2.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlPersonCard2);
            Controls.Add(gbFilters);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(1036, 492);
            Load += ctrlPersonCardWithFilter_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFilters;
        private Label label1;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Button btnAddNewPerson;
        private Button btnFind;
        private ctrlPersonCard ctrlPersonCard1;
        private ctrlPersonCard ctrlPersonCard2;
        private ErrorProvider errorProvider1;
    }
}
