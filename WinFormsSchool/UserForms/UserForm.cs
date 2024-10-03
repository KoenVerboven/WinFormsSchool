

using AppCode.BLL.BLLClasses;

namespace WinFormsSchool.UserForms
{
    public partial class UserForm : Base.BaseForm1
    {
        readonly UserBLL user;
        private readonly DetailFormType _detailFormType;
        int _userId = 0;

        public UserForm(DetailFormType detailFormType)
        {
            InitializeComponent();
            _detailFormType = detailFormType;
            InitializeControls();
            user = new UserBLL();//user met hoofdletter beginnen?
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            #region ButtonControls

            ButtonClose.BackColor = Color.FromArgb(100, 100, 200);
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Height = 35;
            ButtonClose.FlatStyle = FlatStyle.Flat;

            ButtonSave.BackColor = Color.FromArgb(160, 150, 55);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Height = 35;
            ButtonSave.FlatStyle = FlatStyle.Flat;

            ButtonCancel.BackColor = Color.FromArgb(160, 150, 55);
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Height = 35;
            ButtonCancel.FlatStyle = FlatStyle.Flat;

            #endregion

            switch (_detailFormType)
            {
                case DetailFormType.ShowDetailForm:
                    SetAllTextboxesOnFormReadOnly(true);
                    LabelPageTitle.Text = "User Detail";
                    break;
                case DetailFormType.UpdateForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Update User";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    break;
                case DetailFormType.InsertForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Insert User";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    break;
                default:
                    SetAllTextboxesOnFormReadOnly(true);
                    LabelPageTitle.Text = "Student User";
                    break;
            }
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


        public void LoadSelectedUser(int selectedUserId)
        {
            var selectedUser = user.GetUserById(selectedUserId);
            if (selectedUser != null)
            {
                LabelUserIdValue.Text = selectedUser.UserId.ToString();
                TextBoxUserName.Text = selectedUser.UserName;
                DateTimePickerActiveFrom.Value = (DateTime)selectedUser.ActiveFrom;
                CheckBoxBlocked.Checked = selectedUser.Blocked;
                TextBoxPersonId.Text = selectedUser.PersonId.ToString();
                TextBoxSecurityGroupId.Text = selectedUser.SecurityGroupId.ToString();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
