using AppCode.BLL.BLLClasses;
using AppCode.BLL.Enums;
using AppCode.BLL.GeneralClasses;
using AppCode.BLL.Models;
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
            WindowState = FormWindowState.Maximized;   

            SetAllTextboxesOnFormReadOnly(true);
            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            LabelPageTitle.Text = "Student Detail";

            ComboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
            ComboBoxMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            ComboBoxNationality.DataSource = Enum.GetValues(typeof(Nationality));
            ComboBoxSaleryCategorie.DataSource = Enum.GetValues(typeof(SaleryCategorie));
            ComboBoxHighestDegree.DataSource = Enum.GetValues(typeof(HighestDegree));
            ComboBoxStudyDirection.DataSource = Enum.GetValues(typeof(StudyDirection));
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

                if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = !readOnly;
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
                TextBoxNationalRegisterNumber.Text = Convert.ToString(selectedTeacher.NationalRegisterNumber);

                DateTimePickerDateOfBirth.Value = selectedTeacher.DateOfBirth;
                DateTimePickerHireDate.Value = selectedTeacher.HireDate;
                DateTimePickerLeaveDate.Value = ((selectedTeacher.LeaveDate) ?? new DateTime(1900, 1, 1)); // null-coalescing operator

                TextBoxSeniorityYears.Text = Convert.ToString(selectedTeacher.SeniorityYears);
                TextBoxWorkSchedule.Text = Convert.ToString(selectedTeacher.WorkSchedule);
                TextBoxWorkingHoursPerWeek.Text = Convert.ToString(selectedTeacher.WorkingHoursPerWeek);

                ComboBoxGender.Text = Convert.ToString(selectedTeacher.Gender);
                ComboBoxMaritalStatus.Text = Convert.ToString(selectedTeacher.MaritalStatus);
                ComboBoxNationality.Text = Convert.ToString(selectedTeacher.Nationality);
                ComboBoxSaleryCategorie.Text = Convert.ToString(selectedTeacher.SaleryCategorie);
                ComboBoxHighestDegree.Text = Convert.ToString(selectedTeacher.HighestDegree);
                ComboBoxStudyDirection.Text = Convert.ToString(selectedTeacher.StudyDirection);//ToDo studydirection correct? teacher can have more than one studydirection

            }
            catch (Exception oEx)
            {
                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "Form", "TeacherForm" },
                  { "Method", "LoadSelectedTeacher" },
                  { "selectedTeacherId", selectedTeacherId.ToString() }
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
