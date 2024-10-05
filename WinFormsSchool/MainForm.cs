
using AppCode.BLL.Models;
using WinFormsSchool.Course;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsSchool
{
    public partial class MainForm : Form
    {
        /// <summary>
        //  ToDo  check student age min 7 year old (dateofbirth)
        // ToDo  student is loged in : page with student courses + examendates
        // ToDo  write error log to file
        // ToDo  try a popular error log prog, such as Log4Net
        // ToDo  text font in all pages the same : global constant?
        // ToDo  on each form : SetAllTextboxesOnFormReadOnly -> this can better ; don't repeat your self
        // ToDo  Make a DAL layer to connect to sql server
        // ToDo  Correct the tab-order for the controls on each form
        // ToDo User and group security/rights
        // ToDo check the DIRTY state by closing a form
        // ToDo Settings form Only the admin user can access these form; settings such as database connection settings ....
        /// </summary>

        User _validUser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            ToolStripStatusLabel1.Text = _validUser.UserName;
            ToolStripStatusLabel2.Text = "";
            menuStrip1.BackColor = Color.FromArgb(120, 140, 200);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Renderer = new MyRender();
            menuStrip1.Font = new Font("Helvetica", 15);
        }

        public void SetUser(User validUser)
        {
            _validUser = validUser;
            SetUserSecurity(validUser);
        }

        public void SetUserSecurity(User validUser)
        {
            if (validUser.SecurityGroupId == 0)
            {
                MyPersonalDataToolStripMenuItem.Visible = false;
                StudentsToolStripMenuItem.Visible = true;
                SchoolShopToolStripMenuItem.Visible = true;
                TeachersToolStripMenuItem.Visible = true;
                UserAdministraionToolStripMenuItem.Visible = true;
            }

            if (validUser.SecurityGroupId == 1)
            {
                MyPersonalDataToolStripMenuItem.Visible = true;
                StudentsToolStripMenuItem.Visible = false;
                SchoolShopToolStripMenuItem.Visible = false;
                TeachersToolStripMenuItem.Visible = false;
                UserAdministraionToolStripMenuItem.Visible = false;
            }

        }

        private void CloseAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in this.MdiChildren)
            {
                if (!form.Focused)
                {
                    form.Visible = false;
                    form.Close();
                    form.Dispose();
                }
            }
        }


        private void CloseAllForms()
        {
            foreach (var form in this.MdiChildren)
            {
                if (!form.Focused)
                {
                    form.Visible = false;
                    form.Close();
                    form.Dispose();
                }
            }
        }

        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            var studentForm = new StudentSearchForm()
            {
                MdiParent = this
            };
            studentForm.Show();
        }

        private void TeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            var teachersForm = new TeacherSearchForm()
            {
                MdiParent = this
            };
            teachersForm.Show();
        }

        private void SchoolShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            var articleSearchForm = new SchoolArticleSearchForm()
            {
                MdiParent = this
            };
            articleSearchForm.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure clossing the program?", "closing program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            var aboutForm = new AboutForm()
            {
                MdiParent = this
            };
            aboutForm.Show();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            var infoForm = new InfoForm
            {
                MdiParent = this
            };
            infoForm.Show();
        }

        private void MyPersonalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentForm(DetailFormType.ShowDetailForm)
            {
                MdiParent = this
            };
            studentForm.LoadSelectedStudent(_validUser.PersonId);
            studentForm.Show();
        }

        private void UserAdministraionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            var userAdministrationForm = new UserSearchForm()
            {
                MdiParent = this
            };
            userAdministrationForm.Show();
        }

        private void CourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            var courseForm = new CourseSearchForm()
            {
                MdiParent = this
            };
            courseForm.Show();
        }
    }

    internal class MyRender : ToolStripProfessionalRenderer
    {
        public MyRender() : base(new MyColorTable()) { }
    }

    public class MyColorTable : ProfessionalColorTable
    {

        /// <summary>
        /// Gets the starting color of the gradient used when 
        /// a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
        /// </summary>
        public override Color MenuItemPressedGradientBegin => Color.DimGray;

        /// <summary>
        /// Gets the end color of the gradient used when a top-level 
        /// System.Windows.Forms.ToolStripMenuItem is pressed.
        /// </summary>
        public override Color MenuItemPressedGradientEnd => Color.DimGray;

        /// <summary>
        /// Gets the border color to use with a 
        /// System.Windows.Forms.ToolStripMenuItem.
        /// </summary>
        public override Color MenuItemBorder => Color.DarkGray;

        /// <summary>
        /// Gets the starting color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(250, 50, 50);

        /// <summary>
        /// Gets the end color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(250, 50, 50);//(250,140,100);//Color.FromArgb(20,140,250);

        /// <summary>
        /// Gets the solid background color of the 
        /// System.Windows.Forms.ToolStripDropDown.
        /// </summary>
        public override Color ToolStripDropDownBackground => Color.FromArgb(250, 50, 50);

        /// <summary>
        /// Gets the starting color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientBegin => Color.DarkGray;

        /// <summary>
        /// Gets the middle color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientMiddle => Color.DarkGray;

        /// <summary>
        /// Gets the end color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientEnd => Color.DarkGray;

        /// <summary>
        /// Gets the color to use to for shadow effects on 
        /// the System.Windows.Forms.ToolStripSeparator.
        /// </summary>
        public override Color SeparatorDark => Color.Black;

        /// <summary>
        /// Gets the color that is the border color to use 
        /// on a System.Windows.Forms.MenuStrip.
        /// </summary>
        public override Color MenuBorder => Color.DarkGray;
       
    }
}

//icons source:
//<a href="https://www.flaticon.com/free-icons/teacher" title="teacher icons">Teacher icons created by Bert Flint - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/student"title="student icons"> Student icons created by RIkas Dzihab- Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/smart-cart" title="smart cart icons">Smart cart icons created by Freepik - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/info" title="info icons">Info icons created by Stockio - Flaticon</a>
//< a href = "https://www.flaticon.com/free-icons/close" title = "close icons" > Close icons created by Leremy - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/figure" title="figure icons">Figure icons created by heisenberg_jr - Flaticon</a>
//< a href = "https://www.flaticon.com/free-icons/administration" title = "administration icons" > Administration icons created by wuizo - Flaticon</a>
//< a href = "https://www.flaticon.com/free-icons/administrator" title = "administrator icons" > Administrator icons created by smashingstocks - Flaticon</a>
//< a href = "https://www.flaticon.com/free-icons/semester" title = "semester icons" > Semester icons created by zero_wing - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/secure-user" title="secure user icons">Secure user icons created by Muhammad Atif - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/password" title="password icons">Password icons created by Freepik - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/password" title="password icons">Password icons created by Freepik - Flaticon</a>
//<a href="https://www.flaticon.com/free-icons/password" title="password icons">Password icons created by Smashicons - Flaticon</a>
//< a href = "https://www.flaticon.com/free-icons/male" title = "male icons" > Male icons created by sonnycandra - Flaticon</a>
//< a href = "https://www.flaticon.com/free-icons/discover" title = "discover icons" > Discover icons created by Smashicons - Flaticon</a>
//< a href = "https://www.flaticon.com/free-icons/close" title = "close icons" > Close icons created by VectorPortal - Flaticon</a>






