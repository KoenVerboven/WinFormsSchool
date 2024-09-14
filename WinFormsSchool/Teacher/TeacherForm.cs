using AppCode.BLL.BLLClasses;

namespace WinFormsSchool
{
    public partial class TeacherForm : Form
    {
        readonly TeacherBLL Teacher;
        
        public TeacherForm()
        {
            InitializeComponent();
            Height = 610;
            Width = 1100;
            Teacher = new TeacherBLL();
        }


        public void LoadSelectedTeacher(int selectedTeacherId)
        {
            try
            {
                var selectedTeacher = Teacher.GetTeacherById(selectedTeacherId);
                textBoxFirstname.Text = selectedTeacher.Firstname;
                textBoxMiddeleName.Text = selectedTeacher.MiddleName;
                textBoxLastName.Text = selectedTeacher.LastName;
                textBoxStreetAndNumber.Text = selectedTeacher.StreetAndNumber;
                textBoxZipCode.Text = selectedTeacher.ZipCode;
                textBoxPhoneNumber.Text = selectedTeacher.PhoneNumber;
                textBoxEmailAddress.Text = selectedTeacher.EmailAddress;
                textBoxGender.Text = Convert.ToString(selectedTeacher.Gender);
                textBoxDateOfBirth.Text =  Convert.ToString(selectedTeacher.DateOfBirth);
                textBoxMaritalStatus.Text = Convert.ToString(selectedTeacher.MaritalStatus);
                textBoxNationalRegisterNumber.Text = Convert.ToString(selectedTeacher.NationalRegisterNumber);
                textBoxNationality.Text = Convert.ToString(selectedTeacher.Nationality);
                textBoxHireDate.Text = Convert.ToString(selectedTeacher.HireDate);
                textBoxLeaveDate.Text = Convert.ToString(selectedTeacher.LeaveDate);
                textBoxSaleryCategorie.Text = Convert.ToString(selectedTeacher.SaleryCategorie);
                textBoxSeniorityYears.Text = Convert.ToString(selectedTeacher.SeniorityYears);
                textBoxWorkSchedule.Text = Convert.ToString(selectedTeacher.WorkSchedule);
                textBoxWorkingHoursPerWeek.Text = Convert.ToString(selectedTeacher.WorkingHoursPerWeek);
                textBoxHighestDegree.Text = Convert.ToString(selectedTeacher.HighestDegree);
                textBoxStudyDirection.Text = Convert.ToString(selectedTeacher.StudyDirection);
            }
            catch (FormatException)
            {
                string ErrorText = selectedTeacherId + " is not nummeric";
            }
            catch (ArgumentOutOfRangeException)
            {
                 string ErrorText = "Teacher with Id " + selectedTeacherId + " doesn't exist";
                 MessageBox.Show(ErrorText, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception oEx)
            {
                string ErrorText = oEx.Message;
                MessageBox.Show(ErrorText, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
  
    }
}
