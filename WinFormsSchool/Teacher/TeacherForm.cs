using AppCode.BLL.BLLClasses;
using WinFormsSchool.GeneralForms;


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
            LabelPageTitle.Text = "Student Detail";
        }

        private void SetAllTextboxesOnFormReadOnly(bool readOnly)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox textEdit)
                {
                    textEdit.ReadOnly = true;
                }
                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Enabled = !readOnly;
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
                DateTimePickerDateOfBirth.Value = selectedTeacher.DateOfBirth;
                TextBoxMaritalStatus.Text = Convert.ToString(selectedTeacher.MaritalStatus);
                TextBoxNationalRegisterNumber.Text = Convert.ToString(selectedTeacher.NationalRegisterNumber);
                TextBoxNationality.Text = Convert.ToString(selectedTeacher.Nationality);
                DateTimePickerHireDate.Value = selectedTeacher.HireDate;
                DateTimePickerLeaveDate.Value = ((selectedTeacher.LeaveDate) ?? new DateTime(1900, 1, 1)); // null-coalescing operator
                TextBoxSaleryCategorie.Text = Convert.ToString(selectedTeacher.SaleryCategorie);
                TextBoxSeniorityYears.Text = Convert.ToString(selectedTeacher.SeniorityYears);
                TextBoxWorkSchedule.Text = Convert.ToString(selectedTeacher.WorkSchedule);
                TextBoxWorkingHoursPerWeek.Text = Convert.ToString(selectedTeacher.WorkingHoursPerWeek);
                TextBoxHighestDegree.Text = Convert.ToString(selectedTeacher.HighestDegree);
                TextBoxStudyDirection.Text = Convert.ToString(selectedTeacher.StudyDirection);
            }
            catch (ArgumentOutOfRangeException)
            {
                CustomErrorForm customErrorForm = new(
                new( "ArgumentOutOfRangeException.Teacher with Id " + selectedTeacherId + " doesn't exist", 
                     "Admin", "TeacherForm",
                     "LoadSelectedTeacher", false, null, DateTime.Now)
                   );
                customErrorForm.ShowDialog();
            }
            catch (Exception oEx)
            {
                CustomErrorForm customErrorForm = new(
                 new(oEx.Message, "Admin", "TeacherForm",
                       "LoadSelectedTeacher", false, null, DateTime.Now)
                    );
                customErrorForm.ShowDialog();
            }
        }
  
    }
}
