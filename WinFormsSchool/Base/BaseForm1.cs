
namespace WinFormsSchool.Base
{
    public partial class BaseForm1 : Form
    {
        public BaseForm1()
        {
            InitializeComponent();
        }

        private void BaseForm1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(66, 66, 99);
            LabelPageTitle.Font = new Font("Helvetica", 14);
            LabelPageTitle.ForeColor = Color.White;      
        }
    }
}
