using AppCode.BLL.BLLClasses;
using AppCode.BLL.Enums;
using AppCode.BLL.GeneralClasses;
using AppCode.BLL.Models;
using System.Text.RegularExpressions;
using WinFormsSchool.GeneralForms;


namespace WinFormsSchool
{
    public partial class StudentForm : Base.BaseForm1
    {
        readonly StudentBLL Student;
        private readonly DetailFormType _detailFormType;
        int _studentId = 0;

        #region cleanFields

        /// <summary>
        /// ToDo -> place the isDirty logic in a class
        /// ToDo -> check each textbox, chechbox, combobox, datetimepicker,  ..?
        /// </summary>

        string _cleanLastName = "";
        string _cleanMiddleName = "";
        string _cleanFirstName = "";
        string _cleanStreetAndNumber = "";
        string _cleanZipCode = "";
        string _cleanPhoneNumber = "";
        string _cleanEmailAddress = "";
        string _cleanNationalRegisterNr = "";

        int _cleanGender = 0;
        int _cleanMartialStatus = 0;
        int _cleanNationality = 0;

        DateTime _cleanDateOfBirth = DateTime.Now;
        DateTime _cleanRegistrationDate = DateTime.Now;


        #endregion

        public StudentForm(DetailFormType detailFormType)
        {
            InitializeComponent();
            _detailFormType = detailFormType;
            InitializeControls();
            Student = new StudentBLL();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;
            LabelErrorMessage.Visible = false;

            DataGridViewCourses.Visible = false;
            DataGridViewCourses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridViewCourses.ReadOnly = true;

            PanelYellow.BackColor = Color.Yellow;
            PanelYellow.BorderStyle = BorderStyle.FixedSingle;

            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            #region ToolStripStatus

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;

            #endregion

            #region ButtonControls

            ButtonClose.BackColor = Color.FromArgb(100, 100, 200);
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Height = 35;
            ButtonClose.FlatStyle = FlatStyle.Flat;

            ButtonSave.BackColor = Color.FromArgb(160, 150, 55);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Height = 35;
            ButtonSave.FlatStyle = FlatStyle.Flat;

            ButtonCancel.BackColor = Color.FromArgb(160, 150, 55);
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Height = 35;
            ButtonCancel.FlatStyle = FlatStyle.Flat;

            #endregion

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
                    #region FillInControls

                    LabelStudentIdValue.Text = selectedStudent.PersonId.ToString();
                    _studentId = selectedStudent.PersonId;
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

                    #endregion

                    #region SetCleanFields

                    _cleanLastName = TextBoxLastName.Text.Trim();
                    _cleanMiddleName = TextBoxMiddeleName.Text.Trim();
                    _cleanFirstName = TextBoxFirstname.Text.Trim();
                    _cleanStreetAndNumber = TextBoxStreetAndNumber.Text.Trim();
                    _cleanZipCode = TextBoxZipCode.Text.Trim();
                    _cleanPhoneNumber = TextBoxPhoneNumber.Text.Trim();
                    _cleanEmailAddress = TextBoxEmailAddress.Text.Trim();
                    _cleanNationalRegisterNr = TextBoxNationalRegisterNumber.Text.Trim();

                     _cleanGender = ComboBoxGender.SelectedIndex;
                     _cleanMartialStatus = ComboBoxMartialStatus.SelectedIndex;
                     _cleanNationality = ComboBoxNationality.SelectedIndex;

                    _cleanDateOfBirth = DateTimePickerDateOfBirth.Value;
                    _cleanRegistrationDate = DateTimePickerRegistrationdate.Value;

                    #endregion

                    if (selectedStudent.EnrolledCourse != null)
                    {
                        ToolStripStatusLabel1.Text = selectedStudent.EnrolledCourse.Count + " course(s) found for student " + selectedStudent.LastName + " " + selectedStudent.Firstname;
                        #region DataGridViewCourses

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

                        #endregion
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
                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "MoreInfo", "ArgumentOutOfRangeException" },
                  { "Form", "StudentForm" },
                  { "Method", "LoadSelectedStudent" },
                  { "selectedArticleId", selectedStudentId.ToString() }
                };
                var logError = new LogError();
                LogError.LogException(oEx, dictErrorData);

                ShowErrorMessage();
            }
            catch (Exception oEx)
            {
                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "Form", "StudentForm" },
                  { "Method", "LoadSelectedStudent" },
                  { "selectedArticleId", selectedStudentId.ToString() }
                };
                var logError = new LogError();
                LogError.LogException(oEx, dictErrorData);

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
                SaveStudentData();
            }
            //ToDo : insert of update student code
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if 
                (  IsDirty()  && 
                   (_detailFormType == DetailFormType.UpdateForm || _detailFormType == DetailFormType.InsertForm)
                )
            {
                DialogResult result
                    = (MessageBox.Show(
                       "Would you like to save changes before closing?"
                       , "Save Changes"
                       , MessageBoxButtons.YesNoCancel
                       , MessageBoxIcon.Question));

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveStudentData();
                        Close();
                        break;
                    case DialogResult.No:
                        Close();
                        break;
                    case DialogResult.Cancel:
                        // cancel the close
                        //e.Cancel
                        break;
                }
            }
            else
            {
                Close();
            }
        }

        private bool IsDirty()
        {
            #region CheckTextboxes

            if (TextBoxLastName.Text.Trim() != _cleanLastName) return true;
            if (TextBoxFirstname.Text.Trim() != _cleanFirstName) return true;
            if (TextBoxMiddeleName.Text.Trim() != _cleanMiddleName) return true;
            if (TextBoxStreetAndNumber.Text.Trim() != _cleanStreetAndNumber) return true;
            if (TextBoxZipCode.Text.Trim() != _cleanZipCode) return true;
            if (TextBoxPhoneNumber.Text.Trim() != _cleanPhoneNumber) return true;
            if (TextBoxEmailAddress.Text.Trim() != _cleanEmailAddress) return true;
            if (TextBoxNationalRegisterNumber.Text.Trim() != _cleanNationalRegisterNr) return true;

            #endregion

            #region CheckComboBox

            if (ComboBoxGender.SelectedIndex != _cleanGender) return true;
            if (ComboBoxMartialStatus.SelectedIndex != _cleanMartialStatus) return true;
            if (ComboBoxNationality.SelectedIndex != _cleanNationality) return true;

            #endregion

            #region DateTimePicker

            if ( DateTimePickerDateOfBirth.Value.ToShortDateString() != _cleanDateOfBirth.ToShortDateString()) return true;
            if ( DateTimePickerRegistrationdate.Value.ToShortDateString() != _cleanRegistrationDate.ToShortDateString()) return true;

            #endregion

            return false;
        }


        private void SaveStudentData()
        {
            var studentBLL = new StudentBLL();
            bool ok = false;

            var student = new Student() {
                PersonId = _studentId,
                LastName = TextBoxLastName.Text.Trim(),
                MiddleName = TextBoxMiddeleName.Text.Trim(),    
                Firstname = TextBoxFirstname.Text.Trim(),
                StreetAndNumber = TextBoxStreetAndNumber.Text.Trim(),
                ZipCode = TextBoxZipCode.Text.Trim(),
                PhoneNumber = TextBoxPhoneNumber.Text.Trim(),
                EmailAddress = TextBoxEmailAddress.Text.Trim(),
                //Gender = ComboBoxGender.SelectedIndex
                DateOfBirth = DateTimePickerDateOfBirth.Value,
                MoederTongueId = 1,
                // = ComboBoxNationality.SelectedIndex,
                RegistrationDate = DateTimePickerRegistrationdate.Value
            };

            if(_detailFormType == DetailFormType.InsertForm)
            {
                ok = studentBLL.AddStudent(student);
            }

            if(_detailFormType == DetailFormType.UpdateForm)
            {
                ok = studentBLL.UpdateStudent(student);    
            }
            if(ok)
            {
                Close();
            }
        }
    }
}
