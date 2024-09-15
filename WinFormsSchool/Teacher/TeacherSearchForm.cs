﻿
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
            GridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewTeachers.Visible = false;
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            if (TextBoxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                _ = int.TryParse(TextBoxSearch.Text, out int teacherId);
                var searchTeachters = Teacher.GetTeachers();
              
                if(searchTeachters is not null)
                {
                    searchTeachters = searchTeachters
                                 .Where(X => (X.LastName.ToLower() + " " + X.Firstname.ToLower()).Contains(TextBoxSearch.Text.ToLower())
                                        || (X.Firstname.ToLower() + " " + X.LastName.ToLower()).Contains(TextBoxSearch.Text.ToLower())
                                        || (X.PersonId == teacherId)
                                        ).ToList();
                    //boven en onder elke if spatie; toont veel overzichterlijker
                  
                    if (searchTeachters.Count > 0)
                    {
                        GridViewTeachers.DataSource = searchTeachters;
                        GridViewTeachers.Visible = true;
                        GridViewTeachers.Columns["PersonId"].DisplayIndex = 0;
                        GridViewTeachers.Columns["FirstName"].DisplayIndex = 1;
                        GridViewTeachers.Columns["LastName"].DisplayIndex = 2;
                        GridViewTeachers.Columns["DateOfBirth"].DisplayIndex = 3;
                        ToolStripStatusLabel1.Text = "Double click on GridRow to open detailscreen";
                        ToolStripStatusLabel1.Text = searchTeachters.Count.ToString();
                        ToolStripStatusLabel2.Text = "Double click on GridRow to open detailscreen";

                        if (searchTeachters.Count > 1)
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

            }
            else
            {
                ToolStripStatusLabel1.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                GridViewTeachers.Visible = false;
            }
        }

        private void gridViewTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success =  int.TryParse(GridViewTeachers.SelectedRows[0].Cells["PersonId"].Value.ToString(),out int selectedId) ; 
            
            if(success)
            {
                TeacherForm teacherForm = new();
                teacherForm.LoadSelectedTeacher(selectedId);
                teacherForm.ShowDialog(this);
            }
           
        }
    }
}
