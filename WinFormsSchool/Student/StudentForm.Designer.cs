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
            textBoxFirstname = new TextBox();
            textBoxMiddeleName = new TextBox();
            textBoxStreetAndNumber = new TextBox();
            textBoxZipCode = new TextBox();
            textBoxLastName = new TextBox();
            textBoxGender = new TextBox();
            textBoxEmailAddress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridViewCourses = new DataGridView();
            labelCourses = new Label();
            textBoxNationality = new TextBox();
            labelNationality = new Label();
            textBoxDateOfBirth = new TextBox();
            labelDateOfBirth = new Label();
            textBoxMaritalStatus = new TextBox();
            labelMaritalStatus = new Label();
            textBoxNationalRegisterNumber = new TextBox();
            labelNationalRegisterNumber = new Label();
            labelRegistrationDate = new Label();
            textBoxRegistrationDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Location = new Point(222, 36);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(275, 27);
            textBoxFirstname.TabIndex = 0;
            // 
            // textBoxMiddeleName
            // 
            textBoxMiddeleName.Location = new Point(222, 69);
            textBoxMiddeleName.Name = "textBoxMiddeleName";
            textBoxMiddeleName.Size = new Size(275, 27);
            textBoxMiddeleName.TabIndex = 1;
            // 
            // textBoxStreetAndNumber
            // 
            textBoxStreetAndNumber.Location = new Point(222, 135);
            textBoxStreetAndNumber.Name = "textBoxStreetAndNumber";
            textBoxStreetAndNumber.Size = new Size(275, 27);
            textBoxStreetAndNumber.TabIndex = 2;
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.Location = new Point(222, 168);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.Size = new Size(275, 27);
            textBoxZipCode.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(222, 102);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(275, 27);
            textBoxLastName.TabIndex = 7;
            // 
            // textBoxGender
            // 
            textBoxGender.Location = new Point(222, 267);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.Size = new Size(275, 27);
            textBoxGender.TabIndex = 6;
            // 
            // textBoxEmailAddress
            // 
            textBoxEmailAddress.Location = new Point(222, 234);
            textBoxEmailAddress.Name = "textBoxEmailAddress";
            textBoxEmailAddress.Size = new Size(275, 27);
            textBoxEmailAddress.TabIndex = 5;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(222, 201);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(275, 27);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 8;
            label1.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 69);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 9;
            label2.Text = "Middlename";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 102);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 135);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 11;
            label4.Text = "Street and number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 168);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 12;
            label5.Text = "Zipcode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 201);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 13;
            label6.Text = "Phonenumber";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 234);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 14;
            label7.Text = "Emailaddress";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 267);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 15;
            label8.Text = "Gender";
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(35, 357);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.Size = new Size(968, 284);
            dataGridViewCourses.TabIndex = 16;
            dataGridViewCourses.CellFormatting += DataGridViewCourses_CellFormatting;
            // 
            // labelCourses
            // 
            labelCourses.AutoSize = true;
            labelCourses.Location = new Point(37, 323);
            labelCourses.Name = "labelCourses";
            labelCourses.Size = new Size(64, 20);
            labelCourses.TabIndex = 17;
            labelCourses.Text = "Courses ";
            // 
            // textBoxNationality
            // 
            textBoxNationality.Location = new Point(658, 161);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.Size = new Size(349, 27);
            textBoxNationality.TabIndex = 47;
            // 
            // labelNationality
            // 
            labelNationality.AutoSize = true;
            labelNationality.Location = new Point(518, 161);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(82, 20);
            labelNationality.TabIndex = 46;
            labelNationality.Text = "Nationality";
            // 
            // textBoxDateOfBirth
            // 
            textBoxDateOfBirth.Location = new Point(658, 119);
            textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            textBoxDateOfBirth.Size = new Size(345, 27);
            textBoxDateOfBirth.TabIndex = 45;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(518, 122);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(88, 20);
            labelDateOfBirth.TabIndex = 44;
            labelDateOfBirth.Text = "DateOfBirth";
            // 
            // textBoxMaritalStatus
            // 
            textBoxMaritalStatus.Location = new Point(658, 77);
            textBoxMaritalStatus.Name = "textBoxMaritalStatus";
            textBoxMaritalStatus.Size = new Size(345, 27);
            textBoxMaritalStatus.TabIndex = 43;
            // 
            // labelMaritalStatus
            // 
            labelMaritalStatus.AutoSize = true;
            labelMaritalStatus.Location = new Point(517, 84);
            labelMaritalStatus.Name = "labelMaritalStatus";
            labelMaritalStatus.Size = new Size(96, 20);
            labelMaritalStatus.TabIndex = 42;
            labelMaritalStatus.Text = "MaritalStatus";
            // 
            // textBoxNationalRegisterNumber
            // 
            textBoxNationalRegisterNumber.Location = new Point(658, 40);
            textBoxNationalRegisterNumber.Name = "textBoxNationalRegisterNumber";
            textBoxNationalRegisterNumber.Size = new Size(345, 27);
            textBoxNationalRegisterNumber.TabIndex = 41;
            // 
            // labelNationalRegisterNumber
            // 
            labelNationalRegisterNumber.AutoSize = true;
            labelNationalRegisterNumber.Location = new Point(516, 39);
            labelNationalRegisterNumber.Name = "labelNationalRegisterNumber";
            labelNationalRegisterNumber.Size = new Size(136, 20);
            labelNationalRegisterNumber.TabIndex = 40;
            labelNationalRegisterNumber.Text = "NationalRegisterNr";
            // 
            // labelRegistrationDate
            // 
            labelRegistrationDate.AutoSize = true;
            labelRegistrationDate.Location = new Point(518, 201);
            labelRegistrationDate.Name = "labelRegistrationDate";
            labelRegistrationDate.Size = new Size(121, 20);
            labelRegistrationDate.TabIndex = 48;
            labelRegistrationDate.Text = "RegistrationDate";
            // 
            // textBoxRegistrationDate
            // 
            textBoxRegistrationDate.Location = new Point(658, 204);
            textBoxRegistrationDate.Name = "textBoxRegistrationDate";
            textBoxRegistrationDate.Size = new Size(345, 27);
            textBoxRegistrationDate.TabIndex = 49;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 653);
            Controls.Add(textBoxRegistrationDate);
            Controls.Add(labelRegistrationDate);
            Controls.Add(textBoxNationality);
            Controls.Add(labelNationality);
            Controls.Add(textBoxDateOfBirth);
            Controls.Add(labelDateOfBirth);
            Controls.Add(textBoxMaritalStatus);
            Controls.Add(labelMaritalStatus);
            Controls.Add(textBoxNationalRegisterNumber);
            Controls.Add(labelNationalRegisterNumber);
            Controls.Add(labelCourses);
            Controls.Add(dataGridViewCourses);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxGender);
            Controls.Add(textBoxEmailAddress);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxZipCode);
            Controls.Add(textBoxStreetAndNumber);
            Controls.Add(textBoxMiddeleName);
            Controls.Add(textBoxFirstname);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstname;
        private TextBox textBoxMiddeleName;
        private TextBox textBoxStreetAndNumber;
        private TextBox textBoxZipCode;
        private TextBox textBoxLastName;
        private TextBox textBoxGender;
        private TextBox textBoxEmailAddress;
        private TextBox textBoxPhoneNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridViewCourses;
        private Label labelCourses;
        private TextBox textBoxNationality;
        private Label labelNationality;
        private TextBox textBoxDateOfBirth;
        private Label labelDateOfBirth;
        private TextBox textBoxMaritalStatus;
        private Label labelMaritalStatus;
        private TextBox textBoxNationalRegisterNumber;
        private Label labelNationalRegisterNumber;
        private Label labelRegistrationDate;
        private TextBox textBoxRegistrationDate;
    }
}