namespace WinFormsSchool
{
    partial class StudentForm
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
            TextBoxFirstname = new TextBox();
            TextBoxMiddeleName = new TextBox();
            TextBoxStreetAndNumber = new TextBox();
            TextBoxZipCode = new TextBox();
            TextBoxLastName = new TextBox();
            TextBoxEmailAddress = new TextBox();
            TextBoxPhoneNumber = new TextBox();
            LabelFirstname = new Label();
            LabelMiddlename = new Label();
            LabelLastname = new Label();
            LabelStreetandnumber = new Label();
            LabelZipcode = new Label();
            LabelPhonenumber = new Label();
            LabelEmailaddres = new Label();
            LabelGender = new Label();
            DataGridViewCourses = new DataGridView();
            LabelNationality = new Label();
            LabelDateOfBirth = new Label();
            LabelMaritalStatus = new Label();
            TextBoxNationalRegisterNumber = new TextBox();
            LabelNationalRegisterNumber = new Label();
            lLbelRegistrationDate = new Label();
            PanelYellow = new Panel();
            LabelYellow = new Label();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ButtonCancel = new Button();
            ButtonSave = new Button();
            LabelStudentCourses = new Label();
            LabelErrorMessage = new Label();
            DateTimePickerDateOfBirth = new DateTimePicker();
            DateTimePickerRegistrationdate = new DateTimePicker();
            ComboBoxMartialStatus = new ComboBox();
            ComboBoxGender = new ComboBox();
            ComboBoxNationality = new ComboBox();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.Font = new Font("Arial", 14F);
            LabelPageTitle.ForeColor = Color.White;
            LabelPageTitle.Size = new Size(171, 27);
            // 
            // TextBoxFirstname
            // 
            TextBoxFirstname.Location = new Point(224, 113);
            TextBoxFirstname.Name = "TextBoxFirstname";
            TextBoxFirstname.Size = new Size(275, 27);
            TextBoxFirstname.TabIndex = 0;
            // 
            // TextBoxMiddeleName
            // 
            TextBoxMiddeleName.Location = new Point(224, 144);
            TextBoxMiddeleName.Name = "TextBoxMiddeleName";
            TextBoxMiddeleName.Size = new Size(275, 27);
            TextBoxMiddeleName.TabIndex = 1;
            // 
            // TextBoxStreetAndNumber
            // 
            TextBoxStreetAndNumber.Location = new Point(224, 209);
            TextBoxStreetAndNumber.Name = "TextBoxStreetAndNumber";
            TextBoxStreetAndNumber.Size = new Size(275, 27);
            TextBoxStreetAndNumber.TabIndex = 2;
            // 
            // TextBoxZipCode
            // 
            TextBoxZipCode.Location = new Point(224, 242);
            TextBoxZipCode.Name = "TextBoxZipCode";
            TextBoxZipCode.Size = new Size(275, 27);
            TextBoxZipCode.TabIndex = 3;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Location = new Point(224, 176);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(275, 27);
            TextBoxLastName.TabIndex = 7;
            // 
            // TextBoxEmailAddress
            // 
            TextBoxEmailAddress.Location = new Point(224, 308);
            TextBoxEmailAddress.Name = "TextBoxEmailAddress";
            TextBoxEmailAddress.Size = new Size(275, 27);
            TextBoxEmailAddress.TabIndex = 5;
            // 
            // TextBoxPhoneNumber
            // 
            TextBoxPhoneNumber.Location = new Point(224, 275);
            TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            TextBoxPhoneNumber.Size = new Size(275, 27);
            TextBoxPhoneNumber.TabIndex = 4;
            // 
            // LabelFirstname
            // 
            LabelFirstname.AutoSize = true;
            LabelFirstname.Location = new Point(37, 116);
            LabelFirstname.Name = "LabelFirstname";
            LabelFirstname.Size = new Size(73, 20);
            LabelFirstname.TabIndex = 8;
            LabelFirstname.Text = "Firstname";
            // 
            // LabelMiddlename
            // 
            LabelMiddlename.AutoSize = true;
            LabelMiddlename.Location = new Point(37, 146);
            LabelMiddlename.Name = "LabelMiddlename";
            LabelMiddlename.Size = new Size(93, 20);
            LabelMiddlename.TabIndex = 9;
            LabelMiddlename.Text = "Middlename";
            // 
            // LabelLastname
            // 
            LabelLastname.AutoSize = true;
            LabelLastname.Location = new Point(37, 179);
            LabelLastname.Name = "LabelLastname";
            LabelLastname.Size = new Size(72, 20);
            LabelLastname.TabIndex = 10;
            LabelLastname.Text = "Lastname";
            // 
            // LabelStreetandnumber
            // 
            LabelStreetandnumber.AutoSize = true;
            LabelStreetandnumber.Location = new Point(37, 212);
            LabelStreetandnumber.Name = "LabelStreetandnumber";
            LabelStreetandnumber.Size = new Size(132, 20);
            LabelStreetandnumber.TabIndex = 11;
            LabelStreetandnumber.Text = "Street and number";
            // 
            // LabelZipcode
            // 
            LabelZipcode.AutoSize = true;
            LabelZipcode.Location = new Point(37, 245);
            LabelZipcode.Name = "LabelZipcode";
            LabelZipcode.Size = new Size(64, 20);
            LabelZipcode.TabIndex = 12;
            LabelZipcode.Text = "Zipcode";
            // 
            // LabelPhonenumber
            // 
            LabelPhonenumber.AutoSize = true;
            LabelPhonenumber.Location = new Point(37, 278);
            LabelPhonenumber.Name = "LabelPhonenumber";
            LabelPhonenumber.Size = new Size(101, 20);
            LabelPhonenumber.TabIndex = 13;
            LabelPhonenumber.Text = "Phonenumber";
            // 
            // LabelEmailaddres
            // 
            LabelEmailaddres.AutoSize = true;
            LabelEmailaddres.Location = new Point(37, 311);
            LabelEmailaddres.Name = "LabelEmailaddres";
            LabelEmailaddres.Size = new Size(97, 20);
            LabelEmailaddres.TabIndex = 14;
            LabelEmailaddres.Text = "Emailaddress";
            // 
            // LabelGender
            // 
            LabelGender.AutoSize = true;
            LabelGender.Location = new Point(37, 344);
            LabelGender.Name = "LabelGender";
            LabelGender.Size = new Size(57, 20);
            LabelGender.TabIndex = 15;
            LabelGender.Text = "Gender";
            // 
            // DataGridViewCourses
            // 
            DataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCourses.Location = new Point(35, 419);
            DataGridViewCourses.Name = "DataGridViewCourses";
            DataGridViewCourses.RowHeadersWidth = 51;
            DataGridViewCourses.Size = new Size(1016, 262);
            DataGridViewCourses.TabIndex = 16;
            DataGridViewCourses.CellFormatting += DataGridViewCourses_CellFormatting;
            // 
            // LabelNationality
            // 
            LabelNationality.AutoSize = true;
            LabelNationality.Location = new Point(528, 212);
            LabelNationality.Name = "LabelNationality";
            LabelNationality.Size = new Size(82, 20);
            LabelNationality.TabIndex = 46;
            LabelNationality.Text = "Nationality";
            // 
            // LabelDateOfBirth
            // 
            LabelDateOfBirth.AutoSize = true;
            LabelDateOfBirth.Location = new Point(528, 179);
            LabelDateOfBirth.Name = "LabelDateOfBirth";
            LabelDateOfBirth.Size = new Size(88, 20);
            LabelDateOfBirth.TabIndex = 44;
            LabelDateOfBirth.Text = "DateOfBirth";
            // 
            // LabelMaritalStatus
            // 
            LabelMaritalStatus.AutoSize = true;
            LabelMaritalStatus.Location = new Point(528, 147);
            LabelMaritalStatus.Name = "LabelMaritalStatus";
            LabelMaritalStatus.Size = new Size(96, 20);
            LabelMaritalStatus.TabIndex = 42;
            LabelMaritalStatus.Text = "MaritalStatus";
            // 
            // TextBoxNationalRegisterNumber
            // 
            TextBoxNationalRegisterNumber.Location = new Point(708, 113);
            TextBoxNationalRegisterNumber.Name = "TextBoxNationalRegisterNumber";
            TextBoxNationalRegisterNumber.Size = new Size(345, 27);
            TextBoxNationalRegisterNumber.TabIndex = 41;
            // 
            // LabelNationalRegisterNumber
            // 
            LabelNationalRegisterNumber.AutoSize = true;
            LabelNationalRegisterNumber.Location = new Point(528, 116);
            LabelNationalRegisterNumber.Name = "LabelNationalRegisterNumber";
            LabelNationalRegisterNumber.Size = new Size(136, 20);
            LabelNationalRegisterNumber.TabIndex = 40;
            LabelNationalRegisterNumber.Text = "NationalRegisterNr";
            // 
            // lLbelRegistrationDate
            // 
            lLbelRegistrationDate.AutoSize = true;
            lLbelRegistrationDate.Location = new Point(528, 245);
            lLbelRegistrationDate.Name = "lLbelRegistrationDate";
            lLbelRegistrationDate.Size = new Size(121, 20);
            lLbelRegistrationDate.TabIndex = 48;
            lLbelRegistrationDate.Text = "RegistrationDate";
            // 
            // PanelYellow
            // 
            PanelYellow.BackColor = SystemColors.ControlLightLight;
            PanelYellow.Location = new Point(35, 696);
            PanelYellow.Name = "PanelYellow";
            PanelYellow.Size = new Size(22, 23);
            PanelYellow.TabIndex = 50;
            // 
            // LabelYellow
            // 
            LabelYellow.AutoSize = true;
            LabelYellow.Location = new Point(63, 699);
            LabelYellow.Name = "LabelYellow";
            LabelYellow.Size = new Size(302, 20);
            LabelYellow.TabIndex = 51;
            LabelYellow.Text = "-> courses that are currently still in progress ";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 737);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1146, 26);
            statusStrip1.TabIndex = 52;
            statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Padding = new Padding(0, 0, 50, 0);
            ToolStripStatusLabel1.Size = new Size(201, 20);
            ToolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ToolStripStatusLabel2
            // 
            ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            ToolStripStatusLabel2.Size = new Size(151, 20);
            ToolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(271, 54);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 54;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Visible = false;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(165, 53);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(89, 30);
            ButtonSave.TabIndex = 53;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Visible = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // LabelStudentCourses
            // 
            LabelStudentCourses.AutoSize = true;
            LabelStudentCourses.Location = new Point(39, 387);
            LabelStudentCourses.Name = "LabelStudentCourses";
            LabelStudentCourses.Size = new Size(67, 20);
            LabelStudentCourses.TabIndex = 55;
            LabelStudentCourses.Text = "Courses :";
            // 
            // LabelErrorMessage
            // 
            LabelErrorMessage.AutoSize = true;
            LabelErrorMessage.Location = new Point(708, 62);
            LabelErrorMessage.Name = "LabelErrorMessage";
            LabelErrorMessage.Size = new Size(99, 20);
            LabelErrorMessage.TabIndex = 57;
            LabelErrorMessage.Text = "ErrorMessage";
            // 
            // DateTimePickerDateOfBirth
            // 
            DateTimePickerDateOfBirth.Location = new Point(708, 174);
            DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            DateTimePickerDateOfBirth.Size = new Size(343, 27);
            DateTimePickerDateOfBirth.TabIndex = 58;
            // 
            // DateTimePickerRegistrationdate
            // 
            DateTimePickerRegistrationdate.Location = new Point(708, 245);
            DateTimePickerRegistrationdate.Name = "DateTimePickerRegistrationdate";
            DateTimePickerRegistrationdate.Size = new Size(345, 27);
            DateTimePickerRegistrationdate.TabIndex = 59;
            // 
            // ComboBoxMartialStatus
            // 
            ComboBoxMartialStatus.FormattingEnabled = true;
            ComboBoxMartialStatus.Location = new Point(708, 143);
            ComboBoxMartialStatus.Name = "ComboBoxMartialStatus";
            ComboBoxMartialStatus.Size = new Size(345, 28);
            ComboBoxMartialStatus.TabIndex = 60;
            // 
            // ComboBoxGender
            // 
            ComboBoxGender.FormattingEnabled = true;
            ComboBoxGender.Location = new Point(224, 341);
            ComboBoxGender.Name = "ComboBoxGender";
            ComboBoxGender.Size = new Size(275, 28);
            ComboBoxGender.TabIndex = 61;
            // 
            // ComboBoxNationality
            // 
            ComboBoxNationality.FormattingEnabled = true;
            ComboBoxNationality.Location = new Point(708, 211);
            ComboBoxNationality.Name = "ComboBoxNationality";
            ComboBoxNationality.Size = new Size(345, 28);
            ComboBoxNationality.TabIndex = 62;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(44, 53);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 63;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 763);
            Controls.Add(buttonClose);
            Controls.Add(ComboBoxNationality);
            Controls.Add(ComboBoxGender);
            Controls.Add(ComboBoxMartialStatus);
            Controls.Add(DateTimePickerRegistrationdate);
            Controls.Add(DateTimePickerDateOfBirth);
            Controls.Add(LabelErrorMessage);
            Controls.Add(LabelStudentCourses);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(statusStrip1);
            Controls.Add(LabelYellow);
            Controls.Add(PanelYellow);
            Controls.Add(lLbelRegistrationDate);
            Controls.Add(LabelNationality);
            Controls.Add(LabelDateOfBirth);
            Controls.Add(LabelMaritalStatus);
            Controls.Add(TextBoxNationalRegisterNumber);
            Controls.Add(LabelNationalRegisterNumber);
            Controls.Add(DataGridViewCourses);
            Controls.Add(LabelGender);
            Controls.Add(LabelEmailaddres);
            Controls.Add(LabelPhonenumber);
            Controls.Add(LabelZipcode);
            Controls.Add(LabelStreetandnumber);
            Controls.Add(LabelLastname);
            Controls.Add(LabelMiddlename);
            Controls.Add(LabelFirstname);
            Controls.Add(TextBoxLastName);
            Controls.Add(TextBoxEmailAddress);
            Controls.Add(TextBoxPhoneNumber);
            Controls.Add(TextBoxZipCode);
            Controls.Add(TextBoxStreetAndNumber);
            Controls.Add(TextBoxMiddeleName);
            Controls.Add(TextBoxFirstname);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(TextBoxFirstname, 0);
            Controls.SetChildIndex(TextBoxMiddeleName, 0);
            Controls.SetChildIndex(TextBoxStreetAndNumber, 0);
            Controls.SetChildIndex(TextBoxZipCode, 0);
            Controls.SetChildIndex(TextBoxPhoneNumber, 0);
            Controls.SetChildIndex(TextBoxEmailAddress, 0);
            Controls.SetChildIndex(TextBoxLastName, 0);
            Controls.SetChildIndex(LabelFirstname, 0);
            Controls.SetChildIndex(LabelMiddlename, 0);
            Controls.SetChildIndex(LabelLastname, 0);
            Controls.SetChildIndex(LabelStreetandnumber, 0);
            Controls.SetChildIndex(LabelZipcode, 0);
            Controls.SetChildIndex(LabelPhonenumber, 0);
            Controls.SetChildIndex(LabelEmailaddres, 0);
            Controls.SetChildIndex(LabelGender, 0);
            Controls.SetChildIndex(DataGridViewCourses, 0);
            Controls.SetChildIndex(LabelNationalRegisterNumber, 0);
            Controls.SetChildIndex(TextBoxNationalRegisterNumber, 0);
            Controls.SetChildIndex(LabelMaritalStatus, 0);
            Controls.SetChildIndex(LabelDateOfBirth, 0);
            Controls.SetChildIndex(LabelNationality, 0);
            Controls.SetChildIndex(lLbelRegistrationDate, 0);
            Controls.SetChildIndex(PanelYellow, 0);
            Controls.SetChildIndex(LabelYellow, 0);
            Controls.SetChildIndex(statusStrip1, 0);
            Controls.SetChildIndex(ButtonSave, 0);
            Controls.SetChildIndex(ButtonCancel, 0);
            Controls.SetChildIndex(LabelStudentCourses, 0);
            Controls.SetChildIndex(LabelErrorMessage, 0);
            Controls.SetChildIndex(DateTimePickerDateOfBirth, 0);
            Controls.SetChildIndex(DateTimePickerRegistrationdate, 0);
            Controls.SetChildIndex(ComboBoxMartialStatus, 0);
            Controls.SetChildIndex(ComboBoxGender, 0);
            Controls.SetChildIndex(ComboBoxNationality, 0);
            Controls.SetChildIndex(buttonClose, 0);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxFirstname;
        private TextBox TextBoxMiddeleName;
        private TextBox TextBoxStreetAndNumber;
        private TextBox TextBoxZipCode;
        private TextBox TextBoxLastName;
        private TextBox TextBoxEmailAddress;
        private TextBox TextBoxPhoneNumber;
        private Label LabelFirstname;
        private Label LabelMiddlename;
        private Label LabelLastname;
        private Label LabelStreetandnumber;
        private Label LabelZipcode;
        private Label LabelPhonenumber;
        private Label LabelEmailaddres;
        private Label LabelGender;
        private DataGridView DataGridViewCourses;
        private Label LabelNationality;
        private Label LabelDateOfBirth;
        private Label LabelMaritalStatus;
        private TextBox TextBoxNationalRegisterNumber;
        private Label LabelNationalRegisterNumber;
        private Label lLbelRegistrationDate;
        private Panel PanelYellow;
        private Label LabelYellow;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
        public Button ButtonCancel;
        public Button ButtonSave;
        private Label LabelStudentCourses;
        private Label LabelErrorMessage;
        private DateTimePicker DateTimePickerDateOfBirth;
        private DateTimePicker DateTimePickerRegistrationdate;
        private ComboBox ComboBoxMartialStatus;
        private ComboBox ComboBoxGender;
        private ComboBox ComboBoxNationality;
        private Button buttonClose;
    }
}