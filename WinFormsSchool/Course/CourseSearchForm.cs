
namespace WinFormsSchool.Course
{
    public partial class CourseSearchForm : Base.BaseForm1
    {
        public CourseSearchForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;

            LabelPageTitle.Text = "Search Course";
        }

    }
}
