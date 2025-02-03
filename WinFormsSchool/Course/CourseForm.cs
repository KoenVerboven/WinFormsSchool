using AppCode.BLL.BLLClasses;
using AppCode.BLL.Enums;
using AppCode.BLL.GeneralClasses;
using AppCode.BLL.Interfaces;
using System.Windows.Forms;
using WinFormsSchool.GeneralForms;


namespace WinFormsSchool.Course
{
    public partial class CourseForm : Base.BaseForm1
    {
        readonly CourseBLL courseBLL;
        private readonly DetailFormType _detailFormType;
        int _courseId = 0;

        public CourseForm(DetailFormType detailFormType)
        {
            InitializeComponent();
            _detailFormType = detailFormType;
            InitializeControls();
            courseBLL = new CourseBLL();
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;
            LabelErrorMessage.Visible = false;

            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            #region ToolStripStatus

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;

            #endregion

            #region ButtonControls

            ButtonClose.BackColor = Color.White;
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Height = 45;
            ButtonClose.Width = 45;
            ButtonClose.Image = Properties.Resources.back1;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonClose.Text = string.Empty;

            ButtonSave.BackColor = Color.White;
            ButtonSave.Height = 45;
            ButtonSave.Width = 45;
            ButtonSave.Image = Properties.Resources.ok1;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Text = "";

            ButtonCancel.BackColor = Color.White;
            ButtonCancel.Height = 45;
            ButtonCancel.Width = 45;
            ButtonCancel.Image = Properties.Resources.Cancel4;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Text = string.Empty;

            var tooltip = new ToolTip();
            tooltip.SetToolTip(ButtonClose, "Close this page");
            tooltip.SetToolTip(ButtonSave, "Save");
            tooltip.SetToolTip(ButtonCancel, "Cancel");

            #endregion

            switch (_detailFormType)
            {
                case DetailFormType.ShowDetailForm:
                    SetAllTextboxesOnFormReadOnly(true);
                    LabelPageTitle.Text = "Course Detail";
                    break;
                case DetailFormType.UpdateForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Update Course";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    //TODO:UpdateForm
                    //input validation
                    break;
                case DetailFormType.InsertForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Insert Course";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    MarkRequiredFields();
                    //TODO:InsertForm
                    //input validation
                    break;
                default:
                    SetAllTextboxesOnFormReadOnly(true);
                    LabelPageTitle.Text = "Course Detail";
                    break;
            }

        }

        private void MarkRequiredFields()
        {
            var colorRequiredField = Color.FromArgb(200, 200, 251);
            //TextboxCourseName.BackColor = colorRequiredField;
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



        public void LoadSelectedCourse(int selectedCourseId)
        {
            try
            {
                var selectedCourse = courseBLL.GetCourseById(selectedCourseId);

                if (selectedCourse != null)
                {
                    #region FillInControls

                    LabelCourseIdValue.Text = selectedCourse.CourseId.ToString();
                    _courseId = selectedCourse.CourseId;
                    TextBoxCourseName.Text = selectedCourse.CourseName;
                    TextBoxCourseCode.Text = selectedCourse.CourseCode;
                    DateTimePickerStartDate.Value = selectedCourse.StartDate;
                    DateTimePickerEndDate.Value = selectedCourse.EndDate;
                    TextBoxMinimumGradeToPassTheCourse.Text  = Convert.ToString(selectedCourse.MinimumGradeToPassTheCourse);
                    TextBoxMaximumTestCourseGrade.Text = Convert.ToString(selectedCourse.MaximumTestCourseGrade);
                    CheckBoxCourseIsActive.Checked = selectedCourse.CourseIsActive;
                    //ComboBoxCourseType
                    TextBoxCoursePrice.Text = selectedCourse.CoursePrice.ToString();    

                    #endregion

                    #region SetCleanFields

                    // _cleanLastName = TextBoxLastName.Text.Trim();


                    #endregion
                }
            }
            catch (ArgumentOutOfRangeException oEx)
            {
                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "MoreInfo", "ArgumentOutOfRangeException" },
                  { "Form", "CourseForm" },
                  { "Method", "LoadSelectedCourse" },
                  { "selectedCourseId", selectedCourseId.ToString() }
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
                  { "Form", "CourseForm" },
                  { "Method", "LoadSelectedCourse" },
                  { "selectedCourseId", selectedCourseId.ToString() }
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
            //if
            //   (IsDirty() &&
            //      (_detailFormType == DetailFormType.UpdateForm || _detailFormType == DetailFormType.InsertForm)
            //   )
            //{
            //    DialogResult result
            //        = (MessageBox.Show(
            //           "Would you like to save changes before closing?"
            //           , "Save Changes"
            //           , MessageBoxButtons.YesNoCancel
            //           , MessageBoxIcon.Question));

            //    switch (result)
            //    {
            //        case DialogResult.Yes:
            //            SaveCourseData();
            //            Close();
            //            break;
            //        case DialogResult.No:
            //            Close();
            //            break;
            //        case DialogResult.Cancel:
            //            // cancel the close
            //            //e.Cancel
            //            break;
            //    }
            //}
            //else
            //{
                Close();
            //}
        }
    }
}
