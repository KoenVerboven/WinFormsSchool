using WinFormsSchool.Base;

namespace WinFormsSchool
{
    public partial class LoginForm : BaseForm1
    {
        const int maximumNumberOfLoginAttempts = 5;
        int loginAttemptsLeft = maximumNumberOfLoginAttempts;

        //PasswordRequirments:
        const int passwordMinimumCharacters = 5;
        //ToDo Password must contain letters and numbers
        //ToDo Password must contain capital letters and regular letters

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();

            if (CheckLogin())
            {
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
            splitContainer1.Panel1.BackColor = Color.FromArgb(55, 55, 110);
            ButtonPasswordSwitchReadable.Text = string.Empty;
            LabelNumberOfAttemps.Text = string.Empty;
            LabelNumberOfAttemps.ForeColor = Color.FromArgb(240,10,10);
            TextBoxPassWord.PasswordChar = '\u25CF'; //ToDo make password readable with button swich
            TextBoxUserName.Text = "admin"; //ToDo Comment this in live version
        }

        private bool CheckLogin()
        {
            if (TextBoxUserName.Text.Trim() == "admin"
               //&& TextBoxPassWord.Text.Trim() == "schoolsoft4you" //ToDo Comment out this in live version
               )
            {
                return true;
            }
            else
            {
                loginAttemptsLeft -= 1;
                LabelNumberOfAttemps.Text = "You can try " + loginAttemptsLeft + " more times ";
                return false;
            }
        }

        private void ButtonPasswordSwitchReadable_Click(object sender, EventArgs e)
        {
            if(TextBoxPassWord.PasswordChar == '\u25CF')
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
