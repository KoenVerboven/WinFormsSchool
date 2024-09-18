using AppCode.BLL.BLLClasses;
using System.Windows.Forms;

namespace WinFormsSchool
{
    public partial class TeacherForm : Base.BaseForm1
    {
        readonly TeacherBLL Teacher;
        
        public TeacherForm()
        {
            InitializeComponent();
            InitializeControls();
            Teacher = new TeacherBLL();
        }


        private void InitializeControls()
        {
            SetAllTextboxesOnFormReadOnly(true);
            Height = 610;
            Width = 1100;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            LabelTeacherTitle.Font = new Font("Helvetica", 15);
        }

        private void SetAllTextboxesOnFormReadOnly(bool readOnly)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox textEdit)
                {
                    textEdit.ReadOnly = true;
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
                TextBoxDateOfBirth.Text =  selectedTeacher.DateOfBirth.ToString("dd/MM/yyyy");
                TextBoxMaritalStatus.Text = Convert.ToString(selectedTeacher.MaritalStatus);
                TextBoxNationalRegisterNumber.Text = Convert.ToString(selectedTeacher.NationalRegisterNumber);
                TextBoxNationality.Text = Convert.ToString(selectedTeacher.Nationality);
                TextBoxHireDate.Text = selectedTeacher.HireDate.ToString("dd/MM/yyyy");
                TextBoxLeaveDate.Text = Convert.ToString(selectedTeacher.LeaveDate);//todo aanpassen
                TextBoxSaleryCategorie.Text = Convert.ToString(selectedTeacher.SaleryCategorie);
                TextBoxSeniorityYears.Text = Convert.ToString(selectedTeacher.SeniorityYears);
                TextBoxWorkSchedule.Text = Convert.ToString(selectedTeacher.WorkSchedule);
                TextBoxWorkingHoursPerWeek.Text = Convert.ToString(selectedTeacher.WorkingHoursPerWeek);
                TextBoxHighestDegree.Text = Convert.ToString(selectedTeacher.HighestDegree);
                TextBoxStudyDirection.Text = Convert.ToString(selectedTeacher.StudyDirection);
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
