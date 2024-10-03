

namespace WinFormsSchool.UserForms
{
    public partial class UserForm : Base.BaseForm1
    {
        private readonly DetailFormType _detailFormType;


        public UserForm(DetailFormType detailFormType)
        {
            InitializeComponent();
            _detailFormType = detailFormType;
            InitializeControls();
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            switch (_detailFormType)
            {
                case DetailFormType.ShowDetailForm:
                    LabelPageTitle.Text = "User Detail";
                    break;
                case DetailFormType.UpdateForm:
                    LabelPageTitle.Text = "Update User";
                    break;
                case DetailFormType.InsertForm:
                    LabelPageTitle.Text = "Insert User";
                    break;
                default:
                    LabelPageTitle.Text = "Student User";
                    break;
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


        public void LoadSelectedUser(int selectedUserId)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
