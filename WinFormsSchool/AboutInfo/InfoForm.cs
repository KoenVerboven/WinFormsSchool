
using System.Reflection;

namespace WinFormsSchool
{
    public partial class InfoForm : Base.BaseForm1
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LabelPageTitle.Text = "Info";
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            LabelVersioning.Text = String.Format("Application Version {0}", version) + Environment.NewLine;
            LabelInfo.Text = "For more information : go to the files in the Info folder from the project.";//TODO: link maken naar deze files?
        }
    }
}
