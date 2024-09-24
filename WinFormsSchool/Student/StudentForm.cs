using AppCode.BLL.BLLClasses;
using AppCode.BLL.Enums;
using WinFormsSchool.GeneralForms;


namespace WinFormsSchool
{
    public partial class StudentForm : Base.BaseForm1
    {
        readonly StudentBLL Student;
        private readonly DetailFormType _detailFormType;

        public StudentForm(DetailFormType detailFormType)
        {
            InitializeComponent();
            _detailFormType = detailFormType;
            InitializeControls();
            Student = new StudentBLL();
        }

        private void InitializeControls()
        {
            //WindowState = FormWindowState.Maximized;   
            LabelErrorMessage.Visible = false;
            DataGridViewCourses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridViewCourses.Visible = false;
            PanelYellow.BackColor = Color.Yellow;
            PanelYellow.BorderStyle = BorderStyle.FixedSingle;
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;
            DataGridViewCourses.ReadOnly = true;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;

            ButtonSave.BackColor = Color.FromArgb(160, 150, 55);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Height = 35;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonCancel.BackColor = Color.FromArgb(160, 150, 55);
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Height = 35;
            ButtonCancel.FlatStyle = FlatStyle.Flat;

            ComboBoxMartialStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            ComboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
            ComboBoxNationality.DataSource = Enum.GetValues(typeof(Nationality));


            switch (_detailFormType)
            {
                case DetailFormType.ShowDetailForm:
                    SetAllTextboxesOnFormReadOnly(true);
                    LabelPageTitle.Text = "Student Detail";
                    break;
                case DetailFormType.UpdateForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Update Student";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    PanelYellow.Visible = false;
                    LabelYellow.Visible = false;
                    //TODO:UpdateForm
                    //replace some textboxes to dropdowns.......
                    //mark required fields
                    //input validation
                    break;
                case DetailFormType.InsertForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Insert Student";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    PanelYellow.Visible = false;
                    LabelYellow.Visible = false;
                    MarkRequiredFields();
                    //TODO:InsertForm
                    //replace some textboxes to dropdowns.......
                    //mark required fields
                    //input validation
                    break;
                default:
                    SetAllTextboxesOnFormReadOnly(true);
                    LabelPageTitle.Text = "Student Detail";
                    break;
            }

        }

        private void SetAllTextboxesOnFormReadOnly(bool readOnly)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox textEdit)
                {
                    textEdit.ReadOnly = readOnly;
                }
                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Enabled = !readOnly;
                }
                if (control is ComboBox combobox)
                {
                    combobox.Enabled = !readOnly;
                }
            }
        }

        private void SetLabelProperties(Color color, Font font)
        {
            foreach (var control in Controls)
            {
                if (control is Label labelEdit)
                {
                    labelEdit.ForeColor = color;
                    labelEdit.Font = font;
                }
            }
        }

        public void LoadSelectedStudent(int selectedStudentId)
        {
            try
            {
                var selectedStudent = Student.GetStudentById(selectedStudentId);
                if (selectedStudent != null)
                {
                    TextBoxFirstname.Text = selectedStudent.Firstname;
                    TextBoxMiddeleName.Text = selectedStudent.MiddleName;
                    TextBoxLastName.Text = selectedStudent.LastName;
                    TextBoxStreetAndNumber.Text = selectedStudent.StreetAndNumber;
                    TextBoxZipCode.Text = selectedStudent.ZipCode;
                    TextBoxPhoneNumber.Text = selectedStudent.PhoneNumber;
                    TextBoxEmailAddress.Text = selectedStudent.EmailAddress;
                    DateTimePickerDateOfBirth.Value = selectedStudent.DateOfBirth;
                    TextBoxNationalRegisterNumber.Text = Convert.ToString(selectedStudent.NationalRegisterNumber);
                    ComboBoxMartialStatus.Text = Convert.ToString(selectedStudent.MaritalStatus);
                    ComboBoxGender.Text = Convert.ToString(selectedStudent.Gender);
                    ComboBoxNationality.Text = Convert.ToString(selectedStudent.Nationality);
                    DateTimePickerRegistrationdate.Value = selectedStudent.RegistrationDate;

                    if (selectedStudent.EnrolledCourse != null)
                    {
                        ToolStripStatusLabel1.Text = selectedStudent.EnrolledCourse.Count + " course(s) found for student " + selectedStudent.LastName + " " + selectedStudent.Firstname;
                        DataGridViewCourses.DataSource = ((selectedStudent.EnrolledCourse).ToList().OrderByDescending(p => p.StartDate)).ToList();
                        DataGridViewCourses.Columns["TestPassed"].DisplayIndex = 6;
                        DataGridViewCourses.Visible = true;
                        DataGridViewCourses.Columns["CourseId"].Visible = true;
                        DataGridViewCourses.Columns["CourseDescription"].Visible = false;
                        DataGridViewCourses.Columns["CourseName"].ToolTipText = "Yellow means the course is still active";
                        DataGridViewCourses.Columns["CourseIsActive"].Visible = false;
                        DataGridViewCourses.Columns["CourseId"].Width = 50;
                        DataGridViewCourses.Columns["CourseName"].Width = 260;
                        DataGridViewCourses.Columns["TestPassed"].Width = 90;

                    }
                    else
                    {
                        ToolStripStatusLabel1.Text = "No Courses found for student " + selectedStudent.LastName + " " + selectedStudent.Firstname;
                        DataGridViewCourses.Visible = false;
                        PanelYellow.Visible = false;
                        LabelYellow.Visible = false;
                    }
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                CustomErrorForm customErrorForm = new(
                   new("ArgumentOutOfRangeException. Student with Id " + selectedStudentId + " doesn't exist", 
                        "Admin", "StudentForm",
                        "LoadSelectedStudent", false, null, DateTime.Now)
                      );
                customErrorForm.ShowDialog();
            }
            catch (Exception oEx)
            {
                CustomErrorForm customErrorForm = new(
                   new(oEx.Message, "Admin", "StudentForm",
                         "LoadSelectedStudent", false, null, DateTime.Now)
                      );
                customErrorForm.ShowDialog();
            }
        }

        private void DataGridViewCourses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle styleFail = new()
            {
                BackColor = Color.DarkOrange,
                ForeColor = Color.White
            };
            DataGridViewCellStyle stylePass = new()
            {
                BackColor = Color.Green,
                ForeColor = Color.White
            };
            DataGridViewCellStyle styleCourseActive = new()
            {
                BackColor = Color.Yellow,
                ForeColor = Color.Black
            };

            for (int i = 0; i < DataGridViewCourses.Rows.Count; i++)
            {
                if (DataGridViewCourses.Rows[i].Cells["TestPassed"].Value != null)
                {

                    if (DataGridViewCourses.Rows[i].Cells["TestPassed"].Value.ToString() == "True")
                    {
                        DataGridViewCourses.Rows[i].Cells["TestPassed"].Style = stylePass;
                    }

                    if (DataGridViewCourses.Rows[i].Cells["TestPassed"].Value.ToString() == "False")
                    {
                        DataGridViewCourses.Rows[i].Cells["TestPassed"].Style = styleFail;
                    }

                }

                if (DataGridViewCourses.Rows[i].Cells["CourseIsActive"].Value != null)
                {
                    if (DataGridViewCourses.Rows[i].Cells["CourseIsActive"].Value.ToString() == "True")
                    {
                        DataGridViewCourses.Rows[i].Cells["CourseName"].Style = styleCourseActive;
                    }
                }

            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MarkRequiredFields()
        {
            var colorRequiredField = Color.FromArgb(200, 200, 251);
            TextBoxFirstname.BackColor = colorRequiredField;
            TextBoxLastName.BackColor = colorRequiredField;
            TextBoxZipCode.BackColor = colorRequiredField;
        }

        private bool InputValidation()
        {
            LabelErrorMessage.ForeColor = Color.Red;
            if (TextBoxFirstname.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "first name is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }
            if (TextBoxLastName.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "last name is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }
            if (TextBoxZipCode.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "zipcode is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }
           
            //ToDO: check emailaddress


            return true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var ok = InputValidation();
            //ToDo : insert of update student code
        }
   
    }
}
