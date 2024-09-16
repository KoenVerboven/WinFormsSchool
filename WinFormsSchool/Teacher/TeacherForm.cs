using AppCode.BLL.BLLClasses;
using System.Windows.Forms;

namespace WinFormsSchool
{
    public partial class TeacherForm : Form
    {
        readonly TeacherBLL Teacher;
        
        public TeacherForm()
        {
            InitializeComponent();
            InitializeControls();
            Height = 610;
            Width = 1100;
            Teacher = new TeacherBLL();
        }


        private void InitializeControls()
        {
            SetAllTextboxesOnFormReadOnly(true);
        }

        private void SetAllTextboxesOnFormReadOnly(bool readOnly)
        {
            foreach (var control in Controls)
            {
                TextBox? textEdit = control as TextBox;
                if (textEdit != null)
                {
                    textEdit.ReadOnly = true;
                }
            }
        }

        public void LoadSelectedTeacher(int selectedTeacherId)
        {
            try
            {
                var selectedTeacher = Teacher.GetTeacherById(selectedTeacherId);
                TextBoxFirstname.Text = selectedTeacher.Firstname;
                TextBoxMiddeleName.Text = selectedTeacher.MiddleName;
                TextBoxLastName.Text = selectedTeacher.LastName;
                TextBoxStreetAndNumber.Text = selectedTeacher.StreetAndNumber;
                TextBoxZipCode.Text = selectedTeacher.ZipCode;
                TextBoxPhoneNumber.Text = selectedTeacher.PhoneNumber;
                TextBoxEmailAddress.Text = selectedTeacher.EmailAddress;
                TextBoxGender.Text = Convert.ToString(selectedTeacher.Gender);
                TextBoxDateOfBirth.Text =  Convert.ToString(selectedTeacher.DateOfBirth);
                TextBoxMaritalStatus.Text = Convert.ToString(selectedTeacher.MaritalStatus);
                TextBoxNationalRegisterNumber.Text = Convert.ToString(selectedTeacher.NationalRegisterNumber);
                TextBoxNationality.Text = Convert.ToString(selectedTeacher.Nationality);
                TextBoxHireDate.Text = Convert.ToString(selectedTeacher.HireDate);
                TextBoxLeaveDate.Text = Convert.ToString(selectedTeacher.LeaveDate);
                TextBoxSaleryCategorie.Text = Convert.ToString(selectedTeacher.SaleryCategorie);
                TextBoxSeniorityYears.Text = Convert.ToString(selectedTeacher.SeniorityYears);
                TextBoxWorkSchedule.Text = Convert.ToString(selectedTeacher.WorkSchedule);
                TextBoxWorkingHoursPerWeek.Text = Convert.ToString(selectedTeacher.WorkingHoursPerWeek);
                TextBoxHighestDegree.Text = Convert.ToString(selectedTeacher.HighestDegree);
                TextBoxStudyDirection.Text = Convert.ToString(selectedTeacher.StudyDirection);
            }
            catch (FormatException)
            {
                MessageBox.Show(selectedTeacherId + " is not nummeric", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentOutOfRangeException)
            {
                 MessageBox.Show("Teacher with Id " + selectedTeacherId + " doesn't exist", "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
  
    }
}
