
using AppCode.BLL.BLLClasses;
using AppCode.BLL.Models;

namespace WinFormsSchool.UserForms
{
    public partial class UserForm : Base.BaseForm1
    {
        readonly UserBLL user;
        private readonly DetailFormType _detailFormType;
        int _userId = 0;

        #region cleanFields

        /// <summary>
        /// ToDo -> place the isDirty logic in a class
        /// ToDo -> check each textbox, chechbox, combobox, datetimepicker,  ..?
        /// </summary>

        string _cleanUserName = "";
        string _cleanPersonId = ""; //Todo make int
        string _cleanSecurityGroupId = ""; //Todo make int

        #endregion

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

            ButtonClose.BackColor = Color.White;
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Height = 45;
            ButtonClose.Width = 45;
            ButtonClose.Image = Properties.Resources.Close4;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonClose.Text = string.Empty;

            ButtonSave.BackColor = Color.FromArgb(160, 150, 55);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Height = 35;
            ButtonSave.FlatStyle = FlatStyle.Flat;

            ButtonCancel.BackColor = Color.FromArgb(160, 150, 55);
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Height = 35;
            ButtonCancel.FlatStyle = FlatStyle.Flat;

            ButtonResetPassword.BackColor = Color.FromArgb(200, 80, 80);
            ButtonResetPassword.ForeColor = Color.White;
            ButtonResetPassword.Height = 35;
            ButtonResetPassword.FlatStyle = FlatStyle.Flat;

            var ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.ButtonClose, "Close this page");

            LabelErrorMessage.Visible = false;

            #endregion

            switch (_detailFormType)
            {
                case DetailFormType.ShowDetailForm:
                    SetAllTextboxesOnFormReadOnly(true);
                    ButtonResetPassword.Visible = false;
                    LabelPageTitle.Text = "User Detail";
                    break;
                case DetailFormType.UpdateForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Update User";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    ButtonResetPassword.Visible = true;
                    break;
                case DetailFormType.InsertForm:
                    SetAllTextboxesOnFormReadOnly(false);
                    LabelPageTitle.Text = "Insert User";
                    ButtonSave.Visible = true;
                    ButtonCancel.Visible = true;
                    ButtonResetPassword.Visible = false;
                    break;
                default:
                    SetAllTextboxesOnFormReadOnly(true);
                    ButtonResetPassword.Visible = false;
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

                #region FillInControls
                    LabelUserIdValue.Text = selectedUser.UserId.ToString();
                    _userId = selectedUser.UserId;
                    TextBoxUserName.Text = selectedUser.UserName;
                    DateTimePickerActiveFrom.Value = (DateTime)selectedUser.ActiveFrom;
                    CheckBoxBlocked.Checked = selectedUser.Blocked;
                    TextBoxPersonId.Text = selectedUser.PersonId.ToString();
                    TextBoxSecurityGroupId.Text = selectedUser.SecurityGroupId.ToString();
                #endregion

                #region MyRegion
                _cleanUserName = TextBoxUserName.Text.Trim();
                _cleanPersonId = TextBoxPersonId.Text.Trim();
                _cleanSecurityGroupId = TextBoxSecurityGroupId.Text.Trim(); 
                #endregion

            }
        }

        private bool IsDirty()
        {
            #region CheckTextboxes

            if (TextBoxUserName.Text.Trim() != _cleanUserName) return true;
            if (TextBoxSecurityGroupId.Text.Trim() != _cleanSecurityGroupId) return true; 
            if (TextBoxPersonId.Text.Trim() != _cleanPersonId) return true;

            #endregion

            return false;
        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if
              (IsDirty() &&
                 (_detailFormType == DetailFormType.UpdateForm || _detailFormType == DetailFormType.InsertForm)
              )
            {
                DialogResult result
                    = (MessageBox.Show(
                       "Would you like to save changes before closing?"
                       , "Save Changes"
                       , MessageBoxButtons.YesNoCancel
                       , MessageBoxIcon.Question));

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveUserData();
                        Close();
                        break;
                    case DialogResult.No:
                        Close();
                        break;
                    case DialogResult.Cancel:
                        // cancel the close
                        //e.Cancel
                        break;
                }
            }
            else
            {
                Close();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                LabelErrorMessage.Visible = false;
                SaveUserData();
            }
        }

        private bool InputValidation()
        {
            LabelErrorMessage.ForeColor = Color.Red;

            if (TextBoxUserName.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "Username is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxUserName.Text.Trim().Length > 50)
            {
                LabelErrorMessage.Text = "Username maximum lenght is 50 characters";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxSecurityGroupId.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "SecurityGroupId is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }

            if (TextBoxPersonId.Text.Trim() == string.Empty)
            {
                LabelErrorMessage.Text = "PersonId is a required field";
                LabelErrorMessage.Visible = true;
                return false;
            }

            //ToDo check securtigroupid and personid is numeric

            return true;
        }


        private void SaveUserData()
        {
            var userBLL = new UserBLL();
            bool ok = false;

            var user = new User()
            {
                UserId = _userId,
                UserName = TextBoxUserName.Text.Trim(),
                Password = "",
                SecurityGroupId = Convert.ToInt32(TextBoxSecurityGroupId.Text.Trim()), //ToDo test op input is een getal
                ActiveFrom = DateTimePickerActiveFrom.Value,
                Blocked = CheckBoxBlocked.Checked,
                PersonId = Convert.ToInt32(TextBoxPersonId.Text.Trim()) // ToDo test op input is een getal
            };

            if (_detailFormType == DetailFormType.InsertForm)
            {
                ok = userBLL.AddUser(user);
            }

            if (_detailFormType == DetailFormType.UpdateForm)
            {
                ok = userBLL.UpdateUser(user);
            }
            if (ok)
            {
                Close();
            }
        }

        private void ButtonResetPassword_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to reset the password for this user?", "reset password",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if (result == DialogResult.Yes)
            {
                //ToDo ResetPassword  + enscrypt password before writing to database
            }
        }
    }
}
