
using AppCode.BLL.BLLClasses;


namespace WinFormsSchool.Course
{
    public partial class CourseSearchForm : Base.BaseForm1
    {
        readonly CourseBLL courseBLL;
        List<AppCode.BLL.Models.Course> courses;

        public CourseSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            courseBLL = new CourseBLL();
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;

            DataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCourses.Visible = false;
            DataGridViewCourses.ReadOnly = true;
            DataGridViewCourses.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            DataGridViewCourses.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            DataGridViewCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridViewCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);
            DataGridViewCourses.EnableHeadersVisualStyles = false;
            // DataGridViewCourses.Panel2.Padding = new Padding(16);

            ButtonSearch.BackColor = Color.FromArgb(190, 190, 190);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 27;
            ButtonSearch.Width = 29;
            ButtonSearch.Image = Properties.Resources.search1;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonClose.BackColor = Color.White;
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Height = 45;
            ButtonClose.Width = 45;
            ButtonClose.Image = Properties.Resources.Close4;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonClose.Text = string.Empty;

            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            ButtonInsertNewStudent.BackColor = Color.White;
            ButtonInsertNewStudent.Height = 45;
            ButtonInsertNewStudent.Width = 45;
            ButtonInsertNewStudent.Image = Properties.Resources.Plus1;
            ButtonInsertNewStudent.FlatStyle = FlatStyle.Flat;
            ButtonInsertNewStudent.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonInsertNewStudent.Text = string.Empty;

            ButtonUpdate.BackColor = Color.White;
            ButtonUpdate.Height = 45;
            ButtonUpdate.Width = 45;
            ButtonUpdate.Image = Properties.Resources.edit1;
            ButtonUpdate.FlatStyle = FlatStyle.Flat;
            ButtonUpdate.Visible = false;
            ButtonUpdate.Text = string.Empty;

            ButtonDelete.BackColor = Color.White;
            ButtonDelete.Height = 45;
            ButtonDelete.Width = 45;
            ButtonDelete.Image = Properties.Resources.delete1;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Visible = false;
            ButtonDelete.Text = string.Empty;

            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
            //label1.ForeColor = Color.White;
            //label2.ForeColor = Color.White;
            LabelPageTitle.Text = "Search Course";

            var ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.ButtonSearch, "Search");
            var ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.ButtonClose, "Close this page");
            var ToolTip3 = new ToolTip();
            ToolTip3.SetToolTip(this.ButtonInsertNewStudent, "Add new course");
            var ToolTip4 = new ToolTip();
            ToolTip4.SetToolTip(this.ButtonUpdate, "Update course");
            var ToolTip5 = new ToolTip();
            ToolTip5.SetToolTip(this.ButtonDelete, "Delete course");
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

        private void Filter()
        {
             _ = int.TryParse(TextboxSearch.Text, out int courseId);
            courses = courseBLL.GetCourses();
            if (courses is not null)
            {
                 courses = courses
                             .Where(X => (X.CourseName.ToLower() ).Contains(TextboxSearch.Text.ToLower())
                                         || (X.CourseId == courseId)
                 ).ToList();

                if (courses.Count > 0)
                {
                    FillGridView();
                }
                else
                {
                    DataGridViewCourses.Visible = false;
                    ToolStripStatusLabel1.Text = "No courses found";
                    ToolStripStatusLabel2.Text = string.Empty;
                    ButtonUpdate.Visible = false;
                    ButtonDelete.Visible = false;
                }

            }
        }

        private void FillGridView()
        {
            DataGridViewCourses.DataSource = courses;

            DataGridViewCourses.DataSource = null;
            DataGridViewCourses.DataSource = courses;
            DataGridViewCourses.Visible = true;
            ToolStripStatusLabel1.Text = courses.Count.ToString();
            ToolStripStatusLabel2.Text = "Double click on GridRow to open detailscreen";
            if (courses.Count > 1) { ToolStripStatusLabel1.Text += " courses found"; }
            else { ToolStripStatusLabel1.Text += " course found"; }
            ButtonDelete.Visible = true;
            ButtonUpdate.Visible = true;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            try
            {
                ButtonSearch.Enabled = false;
                UseWaitCursor = true;

                if (TextboxSearch.Text.Length >= MinimumCharactersSearchCommand)
                {
                    Filter();
                }
                else
                {
                    ToolStripStatusLabel1.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                    DataGridViewCourses.Visible = false;
                    ButtonUpdate.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ButtonSearch.Enabled = true;
                UseWaitCursor = false;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (DataGridViewCourses.Visible)
            {
                var result = MessageBox.Show("Are you sure closing the Course Search Form? You loosing the search results.", "closing",
             MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void ButtonInsertNewStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implement yet");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implement yet");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implement yet");
        }

        private void DataGridViewCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var succes = int.TryParse(DataGridViewCourses.SelectedRows[0].Cells["CourseId"].Value.ToString(), out int selectedId);
            if (succes)
            {
                CourseForm courseForm = new(DetailFormType.ShowDetailForm)
                {
                    MdiParent = MdiParent
                };
                courseForm.LoadSelectedCourse(selectedId);
                courseForm.Show();
            }
        }
    }
}
