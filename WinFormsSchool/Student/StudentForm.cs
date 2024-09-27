using AppCode.BLL.BLLClasses;
using AppCode.BLL.Enums;
using AppCode.BLL.GeneralClasses;
using System.Reflection;
using System.Text.RegularExpressions;
using WinFormsSchool.GeneralForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            //InitializeControls();
        }

        private void InitializeControls()
        {
            //WindowState = FormWindowState.Maximized;   
            LabelErrorMessage.Visible = false;

            DataGridViewCourses.Visible = false;
            DataGridViewCourses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridViewCourses.ReadOnly = true;

            PanelYellow.BackColor = Color.Yellow;
            PanelYellow.BorderStyle = BorderStyle.FixedSingle;

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;

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
                    //input validation
                    break;
                case DetailFormType.InsertForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Insert Student";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    PanelYellow.Visible = false;
                    LabelYellow.Visible = false;
                    LabelStudentCourses.Visible = false;    
                    MarkRequiredFields();
                    //TODO:InsertForm
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
            catch (ArgumentOutOfRangeException oEx)
            {
                var logError = new LogError();
                logError.LogException(oEx, "", "StudentForm", "LoadSelectedStudent",
                                       "selectedStudentId=" + selectedStudentId, DateTime.Now
                                      );//ToDo fill in user
               
                ShowErrorMessage();
            }
            catch (Exception oEx)
            {
                var logError = new LogError();
                logError.LogException(oEx, "", "StudentForm", "LoadSelectedStudent",
                                       "selectedStudentId=" + selectedStudentId, DateTime.Now
                                      );//ToDo fill in user
                
                ShowErrorMessage();
            }
        }


        private static void ShowErrorMessage()
        {
            CustomErrorForm customErrorForm = new(
                             new("An error occurred. Please try again later.", "", "", "", false, null, DateTime.Now)
                                                 );
            customErrorForm.ShowDialog();
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
                LabelErrorMessage.Text = "Firstname is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxFirstname.Text.Trim().Length > 50)
            {
                LabelErrorMessage.Text = "Firstname maximum lenght is 50 characters";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxLastName.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "Lastname is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxLastName.Text.Trim().Length > 50)
            {
                LabelErrorMessage.Text = "Lastname maximum lenght is 50 characters";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxZipCode.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "zipcode is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxZipCode.Text.Trim().Length > 10)
            {
                LabelErrorMessage.Text = "Zipcode maximum lenght is 10 characters";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxEmailAddress.Text.Trim() != string.Empty)
            {
                if (!EmailIsValid(TextBoxEmailAddress.Text.Trim()))
                {
                    LabelErrorMessage.Text = "Email is not valid";
                    LabelErrorMessage.Visible = true;
                    return false;
                }
            }

            if (TextBoxEmailAddress.Text.Trim().Length > 50)
            {
                LabelErrorMessage.Text = "Email maximum lenght is 50 characters";
                LabelErrorMessage.Visible = true;
                return false;
            }
            //ToDo: check if mobile phonenr is valid
            return true;
        }

        public static bool EmailIsValid(string emailAddress)
        {
            var pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                LabelErrorMessage.Visible = false;
                MessageBox.Show("InputValidation is ok", "validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ToDo : insert of update student code
        }
 
    }
}
