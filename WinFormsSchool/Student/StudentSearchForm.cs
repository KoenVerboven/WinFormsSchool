using AppCode.BLL.BLLClasses;
using System.Data;
using System.Windows.Forms;

namespace WinFormsSchool
{
    public partial class StudentSearchForm : Form
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
            GridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewStudents.Visible = false;
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            if(TextboxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                _ = int.TryParse(TextboxSearch.Text, out int personId);
                var searchStudents = Student.GetStudents();  //onderstaande linq query hoort ook thuis in de bll?  de visuele interface zo dom mogelijk houden
                if(searchStudents is not null)
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
            if(succes)
            {
                StudentForm studentForm = new();
                studentForm.LoadSelectedStudent(selectedId);
                studentForm.ShowDialog(this);
            }
        }
    }
}
