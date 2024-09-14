
using System.Data;
using AppCode.BLL.BLLClasses;

namespace WinFormsSchool
{
    public partial class TeacherSearchForm : Form
    {

        readonly TeacherBLL Teacher;


        public TeacherSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            Teacher = new TeacherBLL();
        }

        private void InitializeControls()
        {
            labelTeachersFound.Text = string.Empty;
            labelTeachersFound.Font = new Font(Font, FontStyle.Italic);
            gridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewTeachers.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            if (textBoxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                _ = int.TryParse(textBoxSearch.Text, out int teacherId);
                var searchTeachters = Teacher.GetTeachers();
              
                if(searchTeachters is not null)
                {
                    searchTeachters = searchTeachters
                                 .Where(X => (X.LastName.ToLower() + " " + X.Firstname.ToLower()).Contains(textBoxSearch.Text.ToLower())
                                        || (X.Firstname.ToLower() + " " + X.LastName.ToLower()).Contains(textBoxSearch.Text.ToLower())
                                        || (X.PersonId == teacherId)
                                        ).ToList();
                    //boven en onder elke if spatie; toont veel overzichterlijker
                  
                    if (searchTeachters.Count > 0)
                    {
                        gridViewTeachers.DataSource = searchTeachters;
                        gridViewTeachers.Visible = true;
                        gridViewTeachers.Columns["PersonId"].DisplayIndex = 0;
                        gridViewTeachers.Columns["FirstName"].DisplayIndex = 1;
                        gridViewTeachers.Columns["LastName"].DisplayIndex = 2;
                        gridViewTeachers.Columns["DateOfBirth"].DisplayIndex = 3;
                        labelTeachersFound.Text = searchTeachters.Count.ToString();
                       
                        if (searchTeachters.Count > 1)
                        { 
                            labelTeachersFound.Text += " teachers found"; 
                        }
                        else
                        {
                            labelTeachersFound.Text += " teacher found"; 
                        }
                    }
                    else
                    {
                        labelTeachersFound.Text = "No teachers found";
                        gridViewTeachers.Visible = false;
                    }
                }

            }
            else
            {
                labelTeachersFound.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                gridViewTeachers.Visible = false;
            }
        }

        private void gridViewTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success =  int.TryParse(gridViewTeachers.SelectedRows[0].Cells["PersonId"].Value.ToString(),out int selectedId) ; 
            
            if(success)
            {
                TeacherForm teacherForm = new();
                teacherForm.LoadSelectedTeacher(selectedId);
                teacherForm.ShowDialog(this);
            }
           
        }
    }
}
