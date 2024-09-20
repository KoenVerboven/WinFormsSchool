using AppCode.BLL.BLLClasses;


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

            if(_detailFormType == DetailFormType.ShowDetailForm)
            {
                SetAllTextboxesOnFormReadOnly(true);
                LabelPageTitle.Text = "Student Detail";
            }

            if (_detailFormType == DetailFormType.UpdateForm)
            {
                SetAllTextboxesOnFormReadOnly(false);
                LabelPageTitle.Text = "Update Student";
            }

            if (_detailFormType == DetailFormType.InsertForm)
            {
                SetAllTextboxesOnFormReadOnly(false);
                LabelPageTitle.Text = "Insert Student";
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
                    TextBoxGender.Text = Convert.ToString(selectedStudent.Gender);
                    TextBoxDateOfBirth.Text = selectedStudent.DateOfBirth.ToString("dd/MM/yyyy");
                    TextBoxMaritalStatus.Text = Convert.ToString(selectedStudent.MaritalStatus);
                    TextBoxNationalRegisterNumber.Text = Convert.ToString(selectedStudent.NationalRegisterNumber);
                    TextBoxNationality.Text = Convert.ToString(selectedStudent.Nationality);
                    TextBoxRegistrationDate.Text = selectedStudent.RegistrationDate.ToString("dd/MM/yyyy");

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

                MessageBox.Show("Student with Id " + selectedStudentId + " doesn't exist", "ErrorMessage",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    }
}
