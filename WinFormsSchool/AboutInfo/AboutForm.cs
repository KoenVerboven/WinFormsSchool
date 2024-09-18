
namespace WinFormsSchool
{
    public partial class AboutForm : Base.BaseForm1
    {
        public AboutForm()
        {
            InitializeComponent();
            SetLabelProperties(Color.Yellow, new Font("Helvetica", 14));
            LabelPageTitle.Text = "About";
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

    }
}
