
using System.Data;
using AppCode.BLL.BLLClasses;
using AppCode.BLL.Models;

namespace WinFormsSchool
{
    public partial class TeacherSearchForm : Base.BaseForm1
    {

        readonly TeacherBLL Teacher;
        List<Teacher> teachers;


        public TeacherSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            Teacher = new TeacherBLL();
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;
            GridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewTeachers.Visible = false;

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;

            GridViewTeachers.ReadOnly = true;
            GridViewTeachers.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            GridViewTeachers.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            GridViewTeachers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GridViewTeachers.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);

            splitContainer1.Panel2.Padding = new Padding(16);

            GridViewTeachers.EnableHeadersVisualStyles = false;

            ButtonSearch.BackColor = Color.FromArgb(190, 190, 190);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 27;
            ButtonSearch.Width = 29;
            ButtonSearch.Image = Properties.Resources.search1;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonClose.BackColor = Color.FromArgb(240, 100, 100);
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Height = 27;
            ButtonClose.Width = 29;
            ButtonClose.Image = Properties.Resources.cross1;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonClose.Text = string.Empty;

            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            LabelPageTitle.Text = "Search Teacher";

            var ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.ButtonSearch, "Search");
            var ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.ButtonClose, "Close this page");
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


        private void GridViewTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success = int.TryParse(GridViewTeachers.SelectedRows[0].Cells["PersonId"].Value.ToString(), out int selectedId);

            if (success)
            {
                TeacherForm teacherForm = new()
                {
                    MdiParent = MdiParent
                };
                teacherForm.LoadSelectedTeacher(selectedId);
                teacherForm.Show();
            }

        }


        private void FillGridView()
        {
            if (teachers.Count > 0)
            {
                GridViewTeachers.DataSource = teachers;
                GridViewTeachers.Visible = true;
                GridViewTeachers.Columns["PersonId"].DisplayIndex = 0;
                GridViewTeachers.Columns["FirstName"].DisplayIndex = 1;
                GridViewTeachers.Columns["LastName"].DisplayIndex = 2;
                GridViewTeachers.Columns["DateOfBirth"].DisplayIndex = 3;
                ToolStripStatusLabel1.Text = teachers.Count.ToString();
                ToolStripStatusLabel2.Text = "Double click on GridRow to open detailscreen";

                if (teachers.Count > 1)
                {
                    ToolStripStatusLabel1.Text += " teachers found";
                }
                else
                {
                    ToolStripStatusLabel1.Text += " teacher found";
                }
            }
            else
            {
                GridViewTeachers.Visible = false;
                ToolStripStatusLabel1.Text = "No teachers found";
                ToolStripStatusLabel2.Text = string.Empty;
            }
        }

        private void ButtonSearch_Click_1(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            if (TextBoxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                _ = int.TryParse(TextBoxSearch.Text, out int teacherId);
                teachers = Teacher.GetTeachers();

                if (teachers is not null)
                {
                    teachers = teachers
                                 .Where(X => (X.LastName.ToLower() + " " + X.Firstname.ToLower()).Contains(TextBoxSearch.Text.ToLower())
                                        || (X.Firstname.ToLower() + " " + X.LastName.ToLower()).Contains(TextBoxSearch.Text.ToLower())
                                        || (X.PersonId == teacherId)
                                        ).ToList();

                    FillGridView();
                }

            }
            else
            {
                ToolStripStatusLabel1.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                GridViewTeachers.Visible = false;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
