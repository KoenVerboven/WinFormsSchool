using AppCode.BLL.BLLClasses;
using System.Data;

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
            labelStudentsFound.Text = string.Empty;
            labelStudentsFound.Font = new Font(Font, FontStyle.Italic);
            gridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewStudents.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            if(textboxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                _ = int.TryParse(textboxSearch.Text, out int personId);
                var searchStudents = Student.GetStudents();  //onderstaande linq query hoort ook thuis in de bll?  de visuele interface zo dom mogelijk houden
                if(searchStudents is not null)
                {
                    searchStudents = searchStudents
                                 .Where(X => (X.LastName.ToLower() + " " + X.Firstname.ToLower()).Contains(textboxSearch.Text.ToLower())
                                           || (X.Firstname.ToLower() + " " + X.LastName.ToLower()).Contains(textboxSearch.Text.ToLower())
                                           || (X.PersonId == personId)
                                           ).ToList();

                    if (searchStudents.Count > 0)
                    {
                        gridViewStudents.DataSource = searchStudents;
                        gridViewStudents.Visible = true;
                        gridViewStudents.Columns["PersonId"].DisplayIndex = 0;
                        gridViewStudents.Columns["FirstName"].DisplayIndex = 1;
                        gridViewStudents.Columns["LastName"].DisplayIndex = 2;
                        gridViewStudents.Columns["DateOfBirth"].DisplayIndex = 3;
                        labelStudentsFound.Text = searchStudents.Count.ToString();
                        if (searchStudents.Count > 1) { labelStudentsFound.Text += " students found"; }
                        else { labelStudentsFound.Text += " student found"; }
                    }
                    else
                    {
                        labelStudentsFound.Text = "No students found";
                        gridViewStudents.Visible = false;
                    }

                }

            }
            else
            {
                labelStudentsFound.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                gridViewStudents.Visible = false;
            }

        }


        private void dgrStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var succes = int.TryParse(gridViewStudents.SelectedRows[0].Cells["PersonId"].Value.ToString(), out int selectedId);
            if(succes)
            {
                StudentForm studentForm = new();
                studentForm.LoadSelectedStudent(selectedId);
                studentForm.ShowDialog(this);
            }
        }
    }
}
