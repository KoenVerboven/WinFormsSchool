using AppCode.BLL.BLLClasses;
using System.Data;
using System.Windows.Forms;

namespace WinFormsSchool
{
    public partial class StudentSearchForm : Base.BaseForm1
    {
        readonly StudentBLL Student;

        public StudentSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            Student = new StudentBLL();
        }

        private void InitializeControls()
        {
            // WindowState = FormWindowState.Maximized;
            GridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewStudents.Visible = false;
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;
            GridViewStudents.ReadOnly = true;
            GridViewStudents.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            GridViewStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            GridViewStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GridViewStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);
            GridViewStudents.EnableHeadersVisualStyles = false;
            splitContainer1.Panel2.Padding = new Padding(16);
            ButtonSearch.BackColor = Color.FromArgb(55, 55, 55);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 35;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            if (TextboxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                _ = int.TryParse(TextboxSearch.Text, out int personId);
                var searchStudents = Student.GetStudents();
                if (searchStudents is not null)
                {
                    searchStudents = searchStudents
                                 .Where(X => (X.LastName.ToLower() + " " + X.Firstname.ToLower()).Contains(TextboxSearch.Text.ToLower())
                                           || (X.Firstname.ToLower() + " " + X.LastName.ToLower()).Contains(TextboxSearch.Text.ToLower())
                                           || (X.PersonId == personId)
                                           ).ToList();

                    if (searchStudents.Count > 0)
                    {
                        GridViewStudents.DataSource = searchStudents;
                        GridViewStudents.Visible = true;
                        GridViewStudents.Columns["PersonId"].DisplayIndex = 0;
                        GridViewStudents.Columns["FirstName"].DisplayIndex = 1;
                        GridViewStudents.Columns["LastName"].DisplayIndex = 2;
                        GridViewStudents.Columns["DateOfBirth"].DisplayIndex = 3;
                        ToolStripStatusLabel1.Text = searchStudents.Count.ToString();
                        ToolStripStatusLabel2.Text = "Double click on GridRow to open detailscreen";
                        if (searchStudents.Count > 1) { ToolStripStatusLabel1.Text += " students found"; }
                        else { ToolStripStatusLabel1.Text += " student found"; }
                    }
                    else
                    {
                        GridViewStudents.Visible = false;
                        ToolStripStatusLabel1.Text = "No students found";
                        ToolStripStatusLabel2.Text = string.Empty;
                    }

                }

            }
            else
            {
                ToolStripStatusLabel1.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                GridViewStudents.Visible = false;
            }

        }

        private void dgrStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var succes = int.TryParse(GridViewStudents.SelectedRows[0].Cells["PersonId"].Value.ToString(), out int selectedId);
            if (succes)
            {
                StudentForm studentForm = new();
                studentForm.MdiParent = MdiParent;
                studentForm.LoadSelectedStudent(selectedId);
                studentForm.Show();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
