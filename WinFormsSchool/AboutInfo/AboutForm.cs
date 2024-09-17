
namespace WinFormsSchool
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(66, 66, 66);
            SetLabelProperties(Color.Yellow, new Font("Helvetica", 14));
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
