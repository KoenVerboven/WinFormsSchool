namespace WinFormsSchool
{
    partial class TeacherForm
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
            TextBoxLastName = new TextBox();
            TextBoxStreetAndNumber = new TextBox();
            TextBoxEmailAddress = new TextBox();
            TextBoxPhoneNumber = new TextBox();
            TextBoxZipCode = new TextBox();
            LabelFirstname = new Label();
            LabelMiddeleName = new Label();
            LabelLastName = new Label();
            LabelStreetAndNumber = new Label();
            LabelGender = new Label();
            LabelEmailAddress = new Label();
            LabelPhoneNumber = new Label();
            LabelZipCode = new Label();
            TextBoxSeniorityYears = new TextBox();
            TextBoxWorkSchedule = new TextBox();
            TextBoxWorkingHoursPerWeek = new TextBox();
            LabelSeniorityYears = new Label();
            LabelSaleryCategorie = new Label();
            LabelLeaveDate = new Label();
            LabelHireDate = new Label();
            LabelStudyDirection = new Label();
            LabelHighestDegree = new Label();
            LabelWorkingHoursPerWeek = new Label();
            LabelWorkSchedule = new Label();
            LabelNationalRegisterNumber = new Label();
            TextBoxNationalRegisterNumber = new TextBox();
            LabelMaritalStatus = new Label();
            LabelDateOfBirth = new Label();
            LabelNationality = new Label();
            DateTimePickerHireDate = new DateTimePicker();
            DateTimePickerDateOfBirth = new DateTimePicker();
            DateTimePickerLeaveDate = new DateTimePicker();
            ComboBoxNationality = new ComboBox();
            ComboBoxMaritalStatus = new ComboBox();
            ComboBoxGender = new ComboBox();
            ComboBoxSaleryCategorie = new ComboBox();
            ComboBoxStudyDirection = new ComboBox();
            ComboBoxHighestDegree = new ComboBox();
            ButtonClose = new Button();
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
            TextBoxFirstname.Location = new Point(226, 123);
            TextBoxFirstname.Name = "TextBoxFirstname";
            TextBoxFirstname.Size = new Size(310, 27);
            TextBoxFirstname.TabIndex = 0;
            // 
            // TextBoxMiddeleName
            // 
            TextBoxMiddeleName.Location = new Point(226, 156);
            TextBoxMiddeleName.Name = "TextBoxMiddeleName";
            TextBoxMiddeleName.Size = new Size(310, 27);
            TextBoxMiddeleName.TabIndex = 1;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Location = new Point(226, 189);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(310, 27);
            TextBoxLastName.TabIndex = 2;
            // 
            // TextBoxStreetAndNumber
            // 
            TextBoxStreetAndNumber.Location = new Point(226, 222);
            TextBoxStreetAndNumber.Name = "TextBoxStreetAndNumber";
            TextBoxStreetAndNumber.Size = new Size(312, 27);
            TextBoxStreetAndNumber.TabIndex = 3;
            // 
            // TextBoxEmailAddress
            // 
            TextBoxEmailAddress.Location = new Point(226, 321);
            TextBoxEmailAddress.Name = "TextBoxEmailAddress";
            TextBoxEmailAddress.Size = new Size(310, 27);
            TextBoxEmailAddress.TabIndex = 6;
            // 
            // TextBoxPhoneNumber
            // 
            TextBoxPhoneNumber.Location = new Point(226, 288);
            TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            TextBoxPhoneNumber.Size = new Size(310, 27);
            TextBoxPhoneNumber.TabIndex = 5;
            // 
            // TextBoxZipCode
            // 
            TextBoxZipCode.Location = new Point(226, 258);
            TextBoxZipCode.Name = "TextBoxZipCode";
            TextBoxZipCode.Size = new Size(310, 27);
            TextBoxZipCode.TabIndex = 4;
            // 
            // LabelFirstname
            // 
            LabelFirstname.AutoSize = true;
            LabelFirstname.Location = new Point(51, 126);
            LabelFirstname.Name = "LabelFirstname";
            LabelFirstname.Size = new Size(73, 20);
            LabelFirstname.TabIndex = 8;
            LabelFirstname.Text = "Firstname";
            // 
            // LabelMiddeleName
            // 
            LabelMiddeleName.AutoSize = true;
            LabelMiddeleName.Location = new Point(51, 159);
            LabelMiddeleName.Name = "LabelMiddeleName";
            LabelMiddeleName.Size = new Size(96, 20);
            LabelMiddeleName.TabIndex = 9;
            LabelMiddeleName.Text = "MiddleName";
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(51, 192);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(75, 20);
            LabelLastName.TabIndex = 10;
            LabelLastName.Text = "LastName";
            // 
            // LabelStreetAndNumber
            // 
            LabelStreetAndNumber.AutoSize = true;
            LabelStreetAndNumber.Location = new Point(51, 225);
            LabelStreetAndNumber.Name = "LabelStreetAndNumber";
            LabelStreetAndNumber.Size = new Size(129, 20);
            LabelStreetAndNumber.TabIndex = 11;
            LabelStreetAndNumber.Text = "StreetAndNumber";
            // 
            // LabelGender
            // 
            LabelGender.AutoSize = true;
            LabelGender.Location = new Point(51, 361);
            LabelGender.Name = "LabelGender";
            LabelGender.Size = new Size(57, 20);
            LabelGender.TabIndex = 15;
            LabelGender.Text = "Gender";
            // 
            // LabelEmailAddress
            // 
            LabelEmailAddress.AutoSize = true;
            LabelEmailAddress.Location = new Point(51, 324);
            LabelEmailAddress.Name = "LabelEmailAddress";
            LabelEmailAddress.Size = new Size(99, 20);
            LabelEmailAddress.TabIndex = 14;
            LabelEmailAddress.Text = "EmailAddress";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Location = new Point(51, 291);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(104, 20);
            LabelPhoneNumber.TabIndex = 13;
            LabelPhoneNumber.Text = "PhoneNumber";
            // 
            // LabelZipCode
            // 
            LabelZipCode.AutoSize = true;
            LabelZipCode.Location = new Point(51, 261);
            LabelZipCode.Name = "LabelZipCode";
            LabelZipCode.Size = new Size(66, 20);
            LabelZipCode.TabIndex = 12;
            LabelZipCode.Text = "ZipCode";
            // 
            // TextBoxSeniorityYears
            // 
            TextBoxSeniorityYears.Location = new Point(785, 222);
            TextBoxSeniorityYears.Name = "TextBoxSeniorityYears";
            TextBoxSeniorityYears.Size = new Size(242, 27);
            TextBoxSeniorityYears.TabIndex = 19;
            // 
            // TextBoxWorkSchedule
            // 
            TextBoxWorkSchedule.Location = new Point(785, 258);
            TextBoxWorkSchedule.Name = "TextBoxWorkSchedule";
            TextBoxWorkSchedule.Size = new Size(242, 27);
            TextBoxWorkSchedule.TabIndex = 20;
            // 
            // TextBoxWorkingHoursPerWeek
            // 
            TextBoxWorkingHoursPerWeek.Location = new Point(785, 288);
            TextBoxWorkingHoursPerWeek.Name = "TextBoxWorkingHoursPerWeek";
            TextBoxWorkingHoursPerWeek.Size = new Size(242, 27);
            TextBoxWorkingHoursPerWeek.TabIndex = 21;
            // 
            // LabelSeniorityYears
            // 
            LabelSeniorityYears.AutoSize = true;
            LabelSeniorityYears.Location = new Point(577, 225);
            LabelSeniorityYears.Name = "LabelSeniorityYears";
            LabelSeniorityYears.Size = new Size(101, 20);
            LabelSeniorityYears.TabIndex = 27;
            LabelSeniorityYears.Text = "SeniorityYears";
            // 
            // LabelSaleryCategorie
            // 
            LabelSaleryCategorie.AutoSize = true;
            LabelSaleryCategorie.Location = new Point(577, 192);
            LabelSaleryCategorie.Name = "LabelSaleryCategorie";
            LabelSaleryCategorie.Size = new Size(114, 20);
            LabelSaleryCategorie.TabIndex = 26;
            LabelSaleryCategorie.Text = "SaleryCategorie";
            // 
            // LabelLeaveDate
            // 
            LabelLeaveDate.AutoSize = true;
            LabelLeaveDate.Location = new Point(577, 159);
            LabelLeaveDate.Name = "LabelLeaveDate";
            LabelLeaveDate.Size = new Size(79, 20);
            LabelLeaveDate.TabIndex = 25;
            LabelLeaveDate.Text = "LeaveDate";
            // 
            // LabelHireDate
            // 
            LabelHireDate.AutoSize = true;
            LabelHireDate.Location = new Point(577, 126);
            LabelHireDate.Name = "LabelHireDate";
            LabelHireDate.Size = new Size(69, 20);
            LabelHireDate.TabIndex = 24;
            LabelHireDate.Text = "HireDate";
            // 
            // LabelStudyDirection
            // 
            LabelStudyDirection.AutoSize = true;
            LabelStudyDirection.Location = new Point(577, 361);
            LabelStudyDirection.Name = "LabelStudyDirection";
            LabelStudyDirection.Size = new Size(107, 20);
            LabelStudyDirection.TabIndex = 31;
            LabelStudyDirection.Text = "StudyDirection";
            // 
            // LabelHighestDegree
            // 
            LabelHighestDegree.AutoSize = true;
            LabelHighestDegree.Location = new Point(577, 324);
            LabelHighestDegree.Name = "LabelHighestDegree";
            LabelHighestDegree.Size = new Size(109, 20);
            LabelHighestDegree.TabIndex = 30;
            LabelHighestDegree.Text = "HighestDegree";
            // 
            // LabelWorkingHoursPerWeek
            // 
            LabelWorkingHoursPerWeek.AutoSize = true;
            LabelWorkingHoursPerWeek.Location = new Point(577, 291);
            LabelWorkingHoursPerWeek.Name = "LabelWorkingHoursPerWeek";
            LabelWorkingHoursPerWeek.Size = new Size(153, 20);
            LabelWorkingHoursPerWeek.TabIndex = 29;
            LabelWorkingHoursPerWeek.Text = "WorkingHours / Week";
            // 
            // LabelWorkSchedule
            // 
            LabelWorkSchedule.AutoSize = true;
            LabelWorkSchedule.Location = new Point(577, 261);
            LabelWorkSchedule.Name = "LabelWorkSchedule";
            LabelWorkSchedule.Size = new Size(103, 20);
            LabelWorkSchedule.TabIndex = 28;
            LabelWorkSchedule.Text = "WorkSchedule";
            // 
            // LabelNationalRegisterNumber
            // 
            LabelNationalRegisterNumber.AutoSize = true;
            LabelNationalRegisterNumber.Location = new Point(51, 393);
            LabelNationalRegisterNumber.Name = "LabelNationalRegisterNumber";
            LabelNationalRegisterNumber.Size = new Size(136, 20);
            LabelNationalRegisterNumber.TabIndex = 32;
            LabelNationalRegisterNumber.Text = "NationalRegisterNr";
            // 
            // TextBoxNationalRegisterNumber
            // 
            TextBoxNationalRegisterNumber.Location = new Point(226, 390);
            TextBoxNationalRegisterNumber.Name = "TextBoxNationalRegisterNumber";
            TextBoxNationalRegisterNumber.Size = new Size(312, 27);
            TextBoxNationalRegisterNumber.TabIndex = 33;
            // 
            // LabelMaritalStatus
            // 
            LabelMaritalStatus.AutoSize = true;
            LabelMaritalStatus.Location = new Point(51, 429);
            LabelMaritalStatus.Name = "LabelMaritalStatus";
            LabelMaritalStatus.Size = new Size(96, 20);
            LabelMaritalStatus.TabIndex = 34;
            LabelMaritalStatus.Text = "MaritalStatus";
            // 
            // LabelDateOfBirth
            // 
            LabelDateOfBirth.AutoSize = true;
            LabelDateOfBirth.Location = new Point(51, 468);
            LabelDateOfBirth.Name = "LabelDateOfBirth";
            LabelDateOfBirth.Size = new Size(88, 20);
            LabelDateOfBirth.TabIndex = 36;
            LabelDateOfBirth.Text = "DateOfBirth";
            // 
            // LabelNationality
            // 
            LabelNationality.AutoSize = true;
            LabelNationality.Location = new Point(51, 509);
            LabelNationality.Name = "LabelNationality";
            LabelNationality.Size = new Size(82, 20);
            LabelNationality.TabIndex = 38;
            LabelNationality.Text = "Nationality";
            // 
            // DateTimePickerHireDate
            // 
            DateTimePickerHireDate.Location = new Point(785, 123);
            DateTimePickerHireDate.Name = "DateTimePickerHireDate";
            DateTimePickerHireDate.Size = new Size(242, 27);
            DateTimePickerHireDate.TabIndex = 42;
            // 
            // DateTimePickerDateOfBirth
            // 
            DateTimePickerDateOfBirth.Location = new Point(226, 463);
            DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            DateTimePickerDateOfBirth.Size = new Size(310, 27);
            DateTimePickerDateOfBirth.TabIndex = 43;
            // 
            // DateTimePickerLeaveDate
            // 
            DateTimePickerLeaveDate.Location = new Point(785, 156);
            DateTimePickerLeaveDate.Name = "DateTimePickerLeaveDate";
            DateTimePickerLeaveDate.Size = new Size(242, 27);
            DateTimePickerLeaveDate.TabIndex = 44;
            // 
            // ComboBoxNationality
            // 
            ComboBoxNationality.FormattingEnabled = true;
            ComboBoxNationality.Location = new Point(226, 506);
            ComboBoxNationality.Name = "ComboBoxNationality";
            ComboBoxNationality.Size = new Size(310, 28);
            ComboBoxNationality.TabIndex = 45;
            // 
            // ComboBoxMaritalStatus
            // 
            ComboBoxMaritalStatus.FormattingEnabled = true;
            ComboBoxMaritalStatus.Location = new Point(226, 429);
            ComboBoxMaritalStatus.Name = "ComboBoxMaritalStatus";
            ComboBoxMaritalStatus.Size = new Size(312, 28);
            ComboBoxMaritalStatus.TabIndex = 46;
            // 
            // ComboBoxGender
            // 
            ComboBoxGender.FormattingEnabled = true;
            ComboBoxGender.Location = new Point(226, 358);
            ComboBoxGender.Name = "ComboBoxGender";
            ComboBoxGender.Size = new Size(310, 28);
            ComboBoxGender.TabIndex = 47;
            // 
            // ComboBoxSaleryCategorie
            // 
            ComboBoxSaleryCategorie.FormattingEnabled = true;
            ComboBoxSaleryCategorie.Location = new Point(782, 189);
            ComboBoxSaleryCategorie.Name = "ComboBoxSaleryCategorie";
            ComboBoxSaleryCategorie.Size = new Size(245, 28);
            ComboBoxSaleryCategorie.TabIndex = 48;
            // 
            // ComboBoxStudyDirection
            // 
            ComboBoxStudyDirection.FormattingEnabled = true;
            ComboBoxStudyDirection.Location = new Point(784, 358);
            ComboBoxStudyDirection.Name = "ComboBoxStudyDirection";
            ComboBoxStudyDirection.Size = new Size(243, 28);
            ComboBoxStudyDirection.TabIndex = 49;
            // 
            // ComboBoxHighestDegree
            // 
            ComboBoxHighestDegree.FormattingEnabled = true;
            ComboBoxHighestDegree.Location = new Point(782, 321);
            ComboBoxHighestDegree.Name = "ComboBoxHighestDegree";
            ComboBoxHighestDegree.Size = new Size(245, 28);
            ComboBoxHighestDegree.TabIndex = 50;
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(50, 62);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(94, 29);
            ButtonClose.TabIndex = 51;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 562);
            Controls.Add(ButtonClose);
            Controls.Add(ComboBoxHighestDegree);
            Controls.Add(ComboBoxStudyDirection);
            Controls.Add(ComboBoxSaleryCategorie);
            Controls.Add(ComboBoxGender);
            Controls.Add(ComboBoxMaritalStatus);
            Controls.Add(ComboBoxNationality);
            Controls.Add(DateTimePickerLeaveDate);
            Controls.Add(DateTimePickerDateOfBirth);
            Controls.Add(DateTimePickerHireDate);
            Controls.Add(LabelNationality);
            Controls.Add(LabelDateOfBirth);
            Controls.Add(LabelMaritalStatus);
            Controls.Add(TextBoxNationalRegisterNumber);
            Controls.Add(LabelNationalRegisterNumber);
            Controls.Add(LabelStudyDirection);
            Controls.Add(LabelHighestDegree);
            Controls.Add(LabelWorkingHoursPerWeek);
            Controls.Add(LabelWorkSchedule);
            Controls.Add(LabelSeniorityYears);
            Controls.Add(LabelSaleryCategorie);
            Controls.Add(LabelLeaveDate);
            Controls.Add(LabelHireDate);
            Controls.Add(TextBoxWorkingHoursPerWeek);
            Controls.Add(TextBoxWorkSchedule);
            Controls.Add(TextBoxSeniorityYears);
            Controls.Add(LabelGender);
            Controls.Add(LabelEmailAddress);
            Controls.Add(LabelPhoneNumber);
            Controls.Add(LabelZipCode);
            Controls.Add(LabelStreetAndNumber);
            Controls.Add(LabelLastName);
            Controls.Add(LabelMiddeleName);
            Controls.Add(LabelFirstname);
            Controls.Add(TextBoxEmailAddress);
            Controls.Add(TextBoxPhoneNumber);
            Controls.Add(TextBoxZipCode);
            Controls.Add(TextBoxStreetAndNumber);
            Controls.Add(TextBoxLastName);
            Controls.Add(TextBoxMiddeleName);
            Controls.Add(TextBoxFirstname);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(TextBoxFirstname, 0);
            Controls.SetChildIndex(TextBoxMiddeleName, 0);
            Controls.SetChildIndex(TextBoxLastName, 0);
            Controls.SetChildIndex(TextBoxStreetAndNumber, 0);
            Controls.SetChildIndex(TextBoxZipCode, 0);
            Controls.SetChildIndex(TextBoxPhoneNumber, 0);
            Controls.SetChildIndex(TextBoxEmailAddress, 0);
            Controls.SetChildIndex(LabelFirstname, 0);
            Controls.SetChildIndex(LabelMiddeleName, 0);
            Controls.SetChildIndex(LabelLastName, 0);
            Controls.SetChildIndex(LabelStreetAndNumber, 0);
            Controls.SetChildIndex(LabelZipCode, 0);
            Controls.SetChildIndex(LabelPhoneNumber, 0);
            Controls.SetChildIndex(LabelEmailAddress, 0);
            Controls.SetChildIndex(LabelGender, 0);
            Controls.SetChildIndex(TextBoxSeniorityYears, 0);
            Controls.SetChildIndex(TextBoxWorkSchedule, 0);
            Controls.SetChildIndex(TextBoxWorkingHoursPerWeek, 0);
            Controls.SetChildIndex(LabelHireDate, 0);
            Controls.SetChildIndex(LabelLeaveDate, 0);
            Controls.SetChildIndex(LabelSaleryCategorie, 0);
            Controls.SetChildIndex(LabelSeniorityYears, 0);
            Controls.SetChildIndex(LabelWorkSchedule, 0);
            Controls.SetChildIndex(LabelWorkingHoursPerWeek, 0);
            Controls.SetChildIndex(LabelHighestDegree, 0);
            Controls.SetChildIndex(LabelStudyDirection, 0);
            Controls.SetChildIndex(LabelNationalRegisterNumber, 0);
            Controls.SetChildIndex(TextBoxNationalRegisterNumber, 0);
            Controls.SetChildIndex(LabelMaritalStatus, 0);
            Controls.SetChildIndex(LabelDateOfBirth, 0);
            Controls.SetChildIndex(LabelNationality, 0);
            Controls.SetChildIndex(DateTimePickerHireDate, 0);
            Controls.SetChildIndex(DateTimePickerDateOfBirth, 0);
            Controls.SetChildIndex(DateTimePickerLeaveDate, 0);
            Controls.SetChildIndex(ComboBoxNationality, 0);
            Controls.SetChildIndex(ComboBoxMaritalStatus, 0);
            Controls.SetChildIndex(ComboBoxGender, 0);
            Controls.SetChildIndex(ComboBoxSaleryCategorie, 0);
            Controls.SetChildIndex(ComboBoxStudyDirection, 0);
            Controls.SetChildIndex(ComboBoxHighestDegree, 0);
            Controls.SetChildIndex(ButtonClose, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxFirstname;
        private TextBox TextBoxMiddeleName;
        private TextBox TextBoxLastName;
        private TextBox TextBoxStreetAndNumber;
        private TextBox TextBoxEmailAddress;
        private TextBox TextBoxPhoneNumber;
        private TextBox TextBoxZipCode;
        private Label LabelFirstname;
        private Label LabelMiddeleName;
        private Label LabelLastName;
        private Label LabelStreetAndNumber;
        private Label LabelGender;
        private Label LabelEmailAddress;
        private Label LabelPhoneNumber;
        private Label LabelZipCode;
        private TextBox TextBoxSeniorityYears;
        private TextBox TextBoxWorkSchedule;
        private TextBox TextBoxWorkingHoursPerWeek;
        private Label LabelSeniorityYears;
        private Label LabelSaleryCategorie;
        private Label LabelLeaveDate;
        private Label LabelHireDate;
        private Label LabelStudyDirection;
        private Label LabelHighestDegree;
        private Label LabelWorkingHoursPerWeek;
        private Label LabelWorkSchedule;
        private Label LabelNationalRegisterNumber;
        private TextBox TextBoxNationalRegisterNumber;
        private Label LabelMaritalStatus;
        private Label LabelDateOfBirth;
        private Label LabelNationality;
        private DateTimePicker DateTimePickerHireDate;
        private DateTimePicker DateTimePickerDateOfBirth;
        private DateTimePicker DateTimePickerLeaveDate;
        private ComboBox ComboBoxNationality;
        private ComboBox ComboBoxMaritalStatus;
        private ComboBox ComboBoxGender;
        private ComboBox ComboBoxSaleryCategorie;
        private ComboBox ComboBoxStudyDirection;
        private ComboBox ComboBoxHighestDegree;
        private Button ButtonClose;
    }
}