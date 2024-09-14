
namespace WinFormsSchool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void schoolArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolArticleForm articlesForm = new SchoolArticleForm();
            articlesForm.MdiParent = this;
            articlesForm.Show();
        }


        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherSearchForm teachersForm = new TeacherSearchForm();
            teachersForm.MdiParent = this;
            teachersForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSearchForm studentForm = new StudentSearchForm();
            studentForm.MdiParent = this;
            studentForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void schoolArticleSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoolArticleSearchForm articleSearchForm = new SchoolArticleSearchForm();
            articleSearchForm.MdiParent = this;
            articleSearchForm.Show();
        }

        private void aboutscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.MdiParent = this;
            infoForm.Show();
        }
    }
}
