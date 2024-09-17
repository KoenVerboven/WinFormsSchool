
using System.Windows.Forms;

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
            menuStrip1.BackColor = Color.FromArgb(55, 55, 55);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Renderer = new MyRender();
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
            StudentSearchForm studentForm = new StudentSearchForm();
            studentForm.MdiParent = this;
            studentForm.Show();
        }

        private void teachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeacherSearchForm teachersForm = new TeacherSearchForm();
            teachersForm.MdiParent = this;
            teachersForm.Show();
        }

        private void schoolShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolArticleSearchForm articleSearchForm = new SchoolArticleSearchForm();
            articleSearchForm.MdiParent = this;
            articleSearchForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.MdiParent = this;
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
        public override Color MenuItemSelectedGradientBegin => Color.DarkBlue;

        /// <summary>
        /// Gets the end color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientEnd => Color.DarkBlue;

        /// <summary>
        /// Gets the solid background color of the 
        /// System.Windows.Forms.ToolStripDropDown.
        /// </summary>
        public override Color ToolStripDropDownBackground => Color.DarkGray;

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
