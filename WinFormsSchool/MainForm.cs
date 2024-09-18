
namespace WinFormsSchool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            ToolStripStatusLabel1.Text = "Admin";
            ToolStripStatusLabel2.Text = "";
            menuStrip1.BackColor = Color.FromArgb(56,60, 77);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Renderer = new MyRender();
            menuStrip1.Font = new Font("Helvetica", 15);
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void studentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentSearchForm studentForm = new()
            {
                MdiParent = this
            };
            studentForm.Show();
        }

        private void teachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeacherSearchForm teachersForm = new()
            {
                MdiParent = this
            };
            teachersForm.Show();
        }

        private void schoolShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolArticleSearchForm articleSearchForm = new()
            {
                MdiParent = this
            };
            articleSearchForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure clossing the program?","closing program",
                MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new()
            {
                MdiParent = this
            };
            aboutForm.Show();
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm
            {
                MdiParent = this
            };
            infoForm.Show();
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
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(99, 129, 130);

        /// <summary>
        /// Gets the end color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(99,129,130);

        /// <summary>
        /// Gets the solid background color of the 
        /// System.Windows.Forms.ToolStripDropDown.
        /// </summary>
        public override Color ToolStripDropDownBackground => Color.FromArgb(99, 129, 130);

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
