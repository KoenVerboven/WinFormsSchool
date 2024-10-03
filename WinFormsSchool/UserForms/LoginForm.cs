using AppCode.BLL.BLLClasses;
using AppCode.BLL.Models;
using WinFormsSchool.Base;

namespace WinFormsSchool
{
    public partial class LoginForm : BaseForm1
    {
        const int maximumNumberOfLoginAttempts = 5;
        int loginAttemptsLeft = maximumNumberOfLoginAttempts;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();

            if (ValidUser() is not null)
            {
                Hide();   
                mainForm.SetUser(ValidUser());
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                if (loginAttemptsLeft == 0)
                {
                    labelMessage.Text = "You have reached the maximum number of login attempts.";
                    ButtonLogin.Visible = false;
                }
                else
                {
                    labelMessage.Text = "Username or PassWord is wrong, try again.";
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LabelPageTitle.Text = string.Empty;
            Width = 850;
            Height = 400;

            labelUserName.ForeColor = Color.White;
            labelPassWord.ForeColor = Color.White;
            labelMessage.Text = string.Empty;
            labelMessage.ForeColor = Color.Red;
            LabelNumberOfAttemps.Text = string.Empty;
            LabelNumberOfAttemps.ForeColor = Color.FromArgb(240, 10, 10);

            splitContainer1.Panel1.BackColor = Color.FromArgb(55, 55, 110);

            TextBoxPassWord.PasswordChar = '\u25CF';
            TextBoxUserName.Text = "admin"; //ToDo Comment this in live version

            ButtonLogin.BackColor = Color.FromArgb(30, 150, 150);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Height = 35;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
        }

        private User? ValidUser()
        {

            UserBLL user = new(); 
            var userFound = user.GetUserByUserNameAndPassword(TextBoxUserName.Text.Trim(), TextBoxPassWord.Text.Trim());

            if (userFound is not null)
            {
                return userFound;
            }
            else
            {
                loginAttemptsLeft -= 1;
                LabelNumberOfAttemps.Text = "You can try " + loginAttemptsLeft + " more times ";
                return null;
            }
        }

        private void CheckBoxShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassWord.Checked)
            {
                TextBoxPassWord.PasswordChar = '\0';
            }
            else
            {
                TextBoxPassWord.PasswordChar = '\u25CF';
            }
        }
    }
}
