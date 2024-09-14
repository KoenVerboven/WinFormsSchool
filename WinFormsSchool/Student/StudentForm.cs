using AppCode.BLL.BLLClasses;


namespace WinFormsSchool
{
    public partial class StudentForm : Form
    {
        readonly StudentBLL Student;

        public StudentForm()
        {
            InitializeComponent();
            InitializeControls();
            Height = 810;
            Width = 1100;
            Student = new StudentBLL();
        }

        private void InitializeControls()
        {
            labelCourses.Text = string.Empty;
            labelCourses.Font = new Font(Font, FontStyle.Italic);
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewCourses.Visible = false;
        }

        public void LoadSelectedStudent(int selectedStudentId)
        {
            try
            {
                var selectedStudent = Student.GetStudentById(selectedStudentId); //selectedStudent met hoofletter beginnen on klein letter?
                if (selectedStudent != null)
                {
                    textBoxFirstname.Text = selectedStudent.Firstname;
                    textBoxMiddeleName.Text = selectedStudent.MiddleName;
                    textBoxLastName.Text = selectedStudent.LastName;
                    textBoxStreetAndNumber.Text = selectedStudent.StreetAndNumber;
                    textBoxZipCode.Text = selectedStudent.ZipCode;
                    textBoxPhoneNumber.Text = selectedStudent.PhoneNumber;
                    textBoxEmailAddress.Text = selectedStudent.EmailAddress;
                    textBoxGender.Text = Convert.ToString(selectedStudent.Gender);
                    textBoxDateOfBirth.Text = selectedStudent.DateOfBirth.ToString("dd/MM/yyyy");
                    textBoxMaritalStatus.Text = Convert.ToString(selectedStudent.MaritalStatus);
                    textBoxNationalRegisterNumber.Text = Convert.ToString(selectedStudent.NationalRegisterNumber);
                    textBoxNationality.Text = Convert.ToString(selectedStudent.Nationality);
                    textBoxRegistrationDate.Text = selectedStudent.RegistrationDate.ToString("dd/MM/yyyy");

                    if (selectedStudent.EnrolledCourse != null)
                    {
                        labelCourses.Text = selectedStudent.EnrolledCourse.Count + " course(s) found for student " + selectedStudent.LastName + " " + selectedStudent.Firstname;
                        dataGridViewCourses.DataSource = ((selectedStudent.EnrolledCourse).ToList().OrderByDescending(p => p.StartDate)).ToList();
                        dataGridViewCourses.Columns["TestPassed"].DisplayIndex = 6;
                        dataGridViewCourses.Visible = true;
                        dataGridViewCourses.Columns["CourseId"].Visible = true;
                        dataGridViewCourses.Columns["CourseDescription"].Visible = false;
                        dataGridViewCourses.Columns["CourseName"].ToolTipText = "Yellow means the course is still active";
                        dataGridViewCourses.Columns["CourseIsActive"].Visible = false;
                        dataGridViewCourses.Columns["CourseId"].Width = 50;
                        dataGridViewCourses.Columns["CourseName"].Width = 260;
                        dataGridViewCourses.Columns["TestPassed"].Width = 90;

                    }
                    else
                    {
                        labelCourses.Text = "No Courses found for student " + selectedStudent.LastName + " " + selectedStudent.Firstname;
                        dataGridViewCourses.Visible = false;
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
                BackColor = Color.Red,
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

            for (int i = 0; i < dataGridViewCourses.Rows.Count; i++)
            {
                if (dataGridViewCourses.Rows[i].Cells["TestPassed"].Value != null)
                {
                    
                    if (dataGridViewCourses.Rows[i].Cells["TestPassed"].Value.ToString() == "True")
                    {
                        dataGridViewCourses.Rows[i].Cells["TestPassed"].Style = stylePass;
                    }
                   
                    if (dataGridViewCourses.Rows[i].Cells["TestPassed"].Value.ToString() == "False")
                    {
                        dataGridViewCourses.Rows[i].Cells["TestPassed"].Style = styleFail;
                    }

                }

                if(dataGridViewCourses.Rows[i].Cells["CourseIsActive"].Value != null)
                {
                    if (dataGridViewCourses.Rows[i].Cells["CourseIsActive"].Value.ToString() == "True")
                    {
                        dataGridViewCourses.Rows[i].Cells["CourseName"].Style = styleCourseActive;
                    }
                }

            }
        }
    }
}
