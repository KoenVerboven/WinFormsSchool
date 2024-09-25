using WinFormsSchool.Base;

namespace WinFormsSchool
{
    public partial class LoginForm : BaseForm1
    {
        const int maximumNumberOfLoginAttempts = 5;
        
        int loginAttemptCounter = 0;

        //PasswordRequirments:
        const int passwordMinimumCharacters = 5;
        //ToDo Password must contain letters and numbers

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
                if (loginAttemptCounter == maximumNumberOfLoginAttempts)
                {
                    labelMessage.Text = "You have reached the maximum number of login attempts. (" + maximumNumberOfLoginAttempts + " times)" ;
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
            LabelPageTitle.Text = string.Empty;//"WinFormsSchool Login";
            Width = 800;
            Height = 400;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            labelMessage.Text = string.Empty;
            labelMessage.ForeColor = Color.Red;
            TextBoxPassWord.PasswordChar = '\u25CF'; //ToDo make password readable with button swich
            TextBoxUserName.Text = "admin"; //ToDo Comment this in live version
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
                loginAttemptCounter += 1;
                return false; 
            }
        }

    }
}
