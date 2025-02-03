namespace WinFormsSchool.Course
{
    partial class CourseForm
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
            LabelCourseId = new Label();
            LabelCourseName = new Label();
            LabelCourseDescription = new Label();
            LabelCourseCode = new Label();
            LabelStartDate = new Label();
            LabelEndDate = new Label();
            labelMinimumGradeToPassTheCourse = new Label();
            LabelMaximumTestCourseGrade = new Label();
            LabelCourseIsActive = new Label();
            LabelCourseType = new Label();
            LabelCoursePrice = new Label();
            labelTeacher = new Label();
            LabelCourseIdValue = new Label();
            TextBoxCourseName = new TextBox();
            TextBoxCourseDescription = new TextBox();
            TextBoxCourseCode = new TextBox();
            DateTimePickerStartDate = new DateTimePicker();
            DateTimePickerEndDate = new DateTimePicker();
            TextBoxMinimumGradeToPassTheCourse = new TextBox();
            TextBoxMaximumTestCourseGrade = new TextBox();
            ComboBoxCourseType = new ComboBox();
            TextBoxCoursePrice = new TextBox();
            ComboBoxTeacher = new ComboBox();
            CheckBoxCourseIsActive = new CheckBox();
            ButtonClose = new Button();
            LabelErrorMessage = new Label();
            ButtonCancel = new Button();
            ButtonSave = new Button();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.Font = new Font("Arial", 14F);
            LabelPageTitle.ForeColor = Color.White;
            LabelPageTitle.Size = new Size(171, 27);
            // 
            // LabelCourseId
            // 
            LabelCourseId.AutoSize = true;
            LabelCourseId.Location = new Point(26, 121);
            LabelCourseId.Name = "LabelCourseId";
            LabelCourseId.Size = new Size(67, 20);
            LabelCourseId.TabIndex = 0;
            LabelCourseId.Text = "CourseId";
            // 
            // LabelCourseName
            // 
            LabelCourseName.AutoSize = true;
            LabelCourseName.Location = new Point(26, 159);
            LabelCourseName.Name = "LabelCourseName";
            LabelCourseName.Size = new Size(94, 20);
            LabelCourseName.TabIndex = 1;
            LabelCourseName.Text = "CourseName";
            // 
            // LabelCourseDescription
            // 
            LabelCourseDescription.AutoSize = true;
            LabelCourseDescription.Location = new Point(594, 121);
            LabelCourseDescription.Name = "LabelCourseDescription";
            LabelCourseDescription.Size = new Size(130, 20);
            LabelCourseDescription.TabIndex = 2;
            LabelCourseDescription.Text = "CourseDescription";
            // 
            // LabelCourseCode
            // 
            LabelCourseCode.AutoSize = true;
            LabelCourseCode.Location = new Point(26, 197);
            LabelCourseCode.Name = "LabelCourseCode";
            LabelCourseCode.Size = new Size(89, 20);
            LabelCourseCode.TabIndex = 3;
            LabelCourseCode.Text = "CourseCode";
            // 
            // LabelStartDate
            // 
            LabelStartDate.AutoSize = true;
            LabelStartDate.Location = new Point(26, 241);
            LabelStartDate.Name = "LabelStartDate";
            LabelStartDate.Size = new Size(72, 20);
            LabelStartDate.TabIndex = 4;
            LabelStartDate.Text = "StartDate";
            // 
            // LabelEndDate
            // 
            LabelEndDate.AutoSize = true;
            LabelEndDate.Location = new Point(26, 281);
            LabelEndDate.Name = "LabelEndDate";
            LabelEndDate.Size = new Size(66, 20);
            LabelEndDate.TabIndex = 5;
            LabelEndDate.Text = "EndDate";
            // 
            // labelMinimumGradeToPassTheCourse
            // 
            labelMinimumGradeToPassTheCourse.AutoSize = true;
            labelMinimumGradeToPassTheCourse.Location = new Point(594, 386);
            labelMinimumGradeToPassTheCourse.Name = "labelMinimumGradeToPassTheCourse";
            labelMinimumGradeToPassTheCourse.Size = new Size(224, 20);
            labelMinimumGradeToPassTheCourse.TabIndex = 6;
            labelMinimumGradeToPassTheCourse.Text = "MinimumGradeToPassTheCourse";
            // 
            // LabelMaximumTestCourseGrade
            // 
            LabelMaximumTestCourseGrade.AutoSize = true;
            LabelMaximumTestCourseGrade.Location = new Point(594, 427);
            LabelMaximumTestCourseGrade.Name = "LabelMaximumTestCourseGrade";
            LabelMaximumTestCourseGrade.Size = new Size(186, 20);
            LabelMaximumTestCourseGrade.TabIndex = 7;
            LabelMaximumTestCourseGrade.Text = "MaximumTestCourseGrade";
            // 
            // LabelCourseIsActive
            // 
            LabelCourseIsActive.AutoSize = true;
            LabelCourseIsActive.Location = new Point(26, 462);
            LabelCourseIsActive.Name = "LabelCourseIsActive";
            LabelCourseIsActive.Size = new Size(105, 20);
            LabelCourseIsActive.TabIndex = 8;
            LabelCourseIsActive.Text = "CourseIsActive";
            // 
            // LabelCourseType
            // 
            LabelCourseType.AutoSize = true;
            LabelCourseType.Location = new Point(30, 317);
            LabelCourseType.Name = "LabelCourseType";
            LabelCourseType.Size = new Size(85, 20);
            LabelCourseType.TabIndex = 9;
            LabelCourseType.Text = "CourseType";
            // 
            // LabelCoursePrice
            // 
            LabelCoursePrice.AutoSize = true;
            LabelCoursePrice.Location = new Point(30, 355);
            LabelCoursePrice.Name = "LabelCoursePrice";
            LabelCoursePrice.Size = new Size(86, 20);
            LabelCoursePrice.TabIndex = 10;
            LabelCoursePrice.Text = "CoursePrice";
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Location = new Point(30, 395);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Size = new Size(60, 20);
            labelTeacher.TabIndex = 11;
            labelTeacher.Text = "Teacher";
            // 
            // LabelCourseIdValue
            // 
            LabelCourseIdValue.AutoSize = true;
            LabelCourseIdValue.Location = new Point(177, 121);
            LabelCourseIdValue.Name = "LabelCourseIdValue";
            LabelCourseIdValue.Size = new Size(50, 20);
            LabelCourseIdValue.TabIndex = 12;
            LabelCourseIdValue.Text = "label1";
            // 
            // TextBoxCourseName
            // 
            TextBoxCourseName.Location = new Point(173, 156);
            TextBoxCourseName.Name = "TextBoxCourseName";
            TextBoxCourseName.Size = new Size(265, 27);
            TextBoxCourseName.TabIndex = 13;
            // 
            // TextBoxCourseDescription
            // 
            TextBoxCourseDescription.Location = new Point(594, 156);
            TextBoxCourseDescription.Multiline = true;
            TextBoxCourseDescription.Name = "TextBoxCourseDescription";
            TextBoxCourseDescription.Size = new Size(428, 192);
            TextBoxCourseDescription.TabIndex = 14;
            // 
            // TextBoxCourseCode
            // 
            TextBoxCourseCode.Location = new Point(173, 194);
            TextBoxCourseCode.Name = "TextBoxCourseCode";
            TextBoxCourseCode.Size = new Size(265, 27);
            TextBoxCourseCode.TabIndex = 15;
            // 
            // DateTimePickerStartDate
            // 
            DateTimePickerStartDate.Location = new Point(173, 237);
            DateTimePickerStartDate.Name = "DateTimePickerStartDate";
            DateTimePickerStartDate.Size = new Size(265, 27);
            DateTimePickerStartDate.TabIndex = 16;
            // 
            // DateTimePickerEndDate
            // 
            DateTimePickerEndDate.Location = new Point(173, 276);
            DateTimePickerEndDate.Name = "DateTimePickerEndDate";
            DateTimePickerEndDate.Size = new Size(265, 27);
            DateTimePickerEndDate.TabIndex = 17;
            // 
            // TextBoxMinimumGradeToPassTheCourse
            // 
            TextBoxMinimumGradeToPassTheCourse.Location = new Point(856, 386);
            TextBoxMinimumGradeToPassTheCourse.Name = "TextBoxMinimumGradeToPassTheCourse";
            TextBoxMinimumGradeToPassTheCourse.Size = new Size(166, 27);
            TextBoxMinimumGradeToPassTheCourse.TabIndex = 18;
            // 
            // TextBoxMaximumTestCourseGrade
            // 
            TextBoxMaximumTestCourseGrade.Location = new Point(856, 427);
            TextBoxMaximumTestCourseGrade.Name = "TextBoxMaximumTestCourseGrade";
            TextBoxMaximumTestCourseGrade.Size = new Size(166, 27);
            TextBoxMaximumTestCourseGrade.TabIndex = 19;
            // 
            // ComboBoxCourseType
            // 
            ComboBoxCourseType.FormattingEnabled = true;
            ComboBoxCourseType.Location = new Point(173, 314);
            ComboBoxCourseType.Name = "ComboBoxCourseType";
            ComboBoxCourseType.Size = new Size(265, 28);
            ComboBoxCourseType.TabIndex = 20;
            // 
            // TextBoxCoursePrice
            // 
            TextBoxCoursePrice.Location = new Point(173, 352);
            TextBoxCoursePrice.Name = "TextBoxCoursePrice";
            TextBoxCoursePrice.Size = new Size(265, 27);
            TextBoxCoursePrice.TabIndex = 21;
            // 
            // ComboBoxTeacher
            // 
            ComboBoxTeacher.FormattingEnabled = true;
            ComboBoxTeacher.Location = new Point(173, 385);
            ComboBoxTeacher.Name = "ComboBoxTeacher";
            ComboBoxTeacher.Size = new Size(265, 28);
            ComboBoxTeacher.TabIndex = 22;
            // 
            // CheckBoxCourseIsActive
            // 
            CheckBoxCourseIsActive.AutoSize = true;
            CheckBoxCourseIsActive.Location = new Point(173, 465);
            CheckBoxCourseIsActive.Name = "CheckBoxCourseIsActive";
            CheckBoxCourseIsActive.Size = new Size(18, 17);
            CheckBoxCourseIsActive.TabIndex = 23;
            CheckBoxCourseIsActive.UseVisualStyleBackColor = true;
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(26, 59);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(94, 29);
            ButtonClose.TabIndex = 67;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LabelErrorMessage
            // 
            LabelErrorMessage.AutoSize = true;
            LabelErrorMessage.Location = new Point(690, 68);
            LabelErrorMessage.Name = "LabelErrorMessage";
            LabelErrorMessage.Size = new Size(99, 20);
            LabelErrorMessage.TabIndex = 66;
            LabelErrorMessage.Text = "ErrorMessage";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(233, 58);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(49, 30);
            ButtonCancel.TabIndex = 65;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Visible = false;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(165, 58);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(53, 30);
            ButtonSave.TabIndex = 64;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 667);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1143, 26);
            statusStrip1.TabIndex = 68;
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
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 693);
            Controls.Add(statusStrip1);
            Controls.Add(ButtonClose);
            Controls.Add(LabelErrorMessage);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(CheckBoxCourseIsActive);
            Controls.Add(ComboBoxTeacher);
            Controls.Add(TextBoxCoursePrice);
            Controls.Add(ComboBoxCourseType);
            Controls.Add(TextBoxMaximumTestCourseGrade);
            Controls.Add(TextBoxMinimumGradeToPassTheCourse);
            Controls.Add(DateTimePickerEndDate);
            Controls.Add(DateTimePickerStartDate);
            Controls.Add(TextBoxCourseCode);
            Controls.Add(TextBoxCourseDescription);
            Controls.Add(TextBoxCourseName);
            Controls.Add(LabelCourseIdValue);
            Controls.Add(labelTeacher);
            Controls.Add(LabelCoursePrice);
            Controls.Add(LabelCourseType);
            Controls.Add(LabelCourseIsActive);
            Controls.Add(LabelMaximumTestCourseGrade);
            Controls.Add(labelMinimumGradeToPassTheCourse);
            Controls.Add(LabelEndDate);
            Controls.Add(LabelStartDate);
            Controls.Add(LabelCourseCode);
            Controls.Add(LabelCourseDescription);
            Controls.Add(LabelCourseName);
            Controls.Add(LabelCourseId);
            Name = "CourseForm";
            Text = "CourseForm";
            Controls.SetChildIndex(LabelCourseId, 0);
            Controls.SetChildIndex(LabelCourseName, 0);
            Controls.SetChildIndex(LabelCourseDescription, 0);
            Controls.SetChildIndex(LabelCourseCode, 0);
            Controls.SetChildIndex(LabelStartDate, 0);
            Controls.SetChildIndex(LabelEndDate, 0);
            Controls.SetChildIndex(labelMinimumGradeToPassTheCourse, 0);
            Controls.SetChildIndex(LabelMaximumTestCourseGrade, 0);
            Controls.SetChildIndex(LabelCourseIsActive, 0);
            Controls.SetChildIndex(LabelCourseType, 0);
            Controls.SetChildIndex(LabelCoursePrice, 0);
            Controls.SetChildIndex(labelTeacher, 0);
            Controls.SetChildIndex(LabelCourseIdValue, 0);
            Controls.SetChildIndex(TextBoxCourseName, 0);
            Controls.SetChildIndex(TextBoxCourseDescription, 0);
            Controls.SetChildIndex(TextBoxCourseCode, 0);
            Controls.SetChildIndex(DateTimePickerStartDate, 0);
            Controls.SetChildIndex(DateTimePickerEndDate, 0);
            Controls.SetChildIndex(TextBoxMinimumGradeToPassTheCourse, 0);
            Controls.SetChildIndex(TextBoxMaximumTestCourseGrade, 0);
            Controls.SetChildIndex(ComboBoxCourseType, 0);
            Controls.SetChildIndex(TextBoxCoursePrice, 0);
            Controls.SetChildIndex(ComboBoxTeacher, 0);
            Controls.SetChildIndex(CheckBoxCourseIsActive, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(ButtonSave, 0);
            Controls.SetChildIndex(ButtonCancel, 0);
            Controls.SetChildIndex(LabelErrorMessage, 0);
            Controls.SetChildIndex(ButtonClose, 0);
            Controls.SetChildIndex(statusStrip1, 0);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCourseId;
        private Label LabelCourseName;
        private Label LabelCourseDescription;
        private Label LabelCourseCode;
        private Label LabelStartDate;
        private Label LabelEndDate;
        private Label labelMinimumGradeToPassTheCourse;
        private Label LabelMaximumTestCourseGrade;
        private Label LabelCourseIsActive;
        private Label LabelCourseType;
        private Label LabelCoursePrice;
        private Label labelTeacher;
        private Label LabelCourseIdValue;
        private TextBox TextBoxCourseName;
        private TextBox TextBoxCourseDescription;
        private TextBox TextBoxCourseCode;
        private DateTimePicker DateTimePickerStartDate;
        private DateTimePicker DateTimePickerEndDate;
        private TextBox TextBoxMinimumGradeToPassTheCourse;
        private TextBox TextBoxMaximumTestCourseGrade;
        private ComboBox ComboBoxCourseType;
        private TextBox TextBoxCoursePrice;
        private ComboBox ComboBoxTeacher;
        private CheckBox CheckBoxCourseIsActive;
        private Button ButtonClose;
        private Label LabelErrorMessage;
        public Button ButtonCancel;
        public Button ButtonSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
    }
}