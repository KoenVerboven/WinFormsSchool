﻿using AppCode.BLL.BLLClasses;
using AppCode.BLL.Models;
using System.Data;


namespace WinFormsSchool
{
    public partial class StudentSearchForm : Base.BaseForm1
    {
        readonly StudentBLL Student;
        List<Student> students; // rename to students

        public StudentSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            Student = new StudentBLL();
        }

        private void InitializeControls()
        {
            // WindowState = FormWindowState.Maximized;
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel1.Font = new Font(Font, FontStyle.Italic);
            ToolStripStatusLabel2.Text = string.Empty;
            GridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewStudents.Visible = false;
            GridViewStudents.ReadOnly = true;
            GridViewStudents.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            GridViewStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            GridViewStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GridViewStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);
            GridViewStudents.EnableHeadersVisualStyles = false;
            splitContainer1.Panel2.Padding = new Padding(16);
            ButtonSearch.BackColor = Color.FromArgb(55, 150, 55);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 35;
            ButtonSearch.Image = Properties.Resources.SearchIcon;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            ButtonDelete.BackColor = Color.FromArgb(200, 50, 50);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Height = 35;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Visible = false;
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            LabelPageTitle.Text = "Search Student";
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
                students = Student.GetStudents();
                if (students is not null)
                {
                    students = students
                                 .Where(X => (X.LastName.ToLower() + " " + X.Firstname.ToLower()).Contains(TextboxSearch.Text.ToLower())
                                           || (X.Firstname.ToLower() + " " + X.LastName.ToLower()).Contains(TextboxSearch.Text.ToLower())
                                           || (X.PersonId == personId)
                                           ).ToList();

                    FillGridView();
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
                StudentForm studentForm = new(DetailFormType.ShowDetailForm)
                {
                    MdiParent = MdiParent
                };
                studentForm.LoadSelectedStudent(selectedId);
                studentForm.Show();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure delete the selected person "
                                             + GridViewStudents.SelectedRows[0].Cells["FullName"].Value.ToString() + " ?"
                                             , "Delete Student",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    var success = int.TryParse(GridViewStudents.SelectedRows[0].Cells["PersonId"].Value.ToString(), out int selectedId);
                    if (success)
                    {
                        var itemRemove = students.Single(r => r.PersonId == selectedId);

                        if (itemRemove != null)
                        {
                           
                            if (itemRemove.EnrolledCourse == null)
                            {
                                students.Remove(itemRemove);
                            }
                            else
                            {
                                MessageBox.Show("You can not remove a student with course(s)", "ErrorMessage", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }

                        FillGridView();
                    }
                }

            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillGridView()
        {
            if (students.Count > 0)
            {
                GridViewStudents.DataSource = students;
                if (students.Count > 0)
                {
                    GridViewStudents.DataSource = null;
                    GridViewStudents.DataSource = students;
                    GridViewStudents.Visible = true;
                    GridViewStudents.Columns["PersonId"].DisplayIndex = 0;
                    GridViewStudents.Columns["FirstName"].DisplayIndex = 1;
                    GridViewStudents.Columns["LastName"].DisplayIndex = 2;
                    GridViewStudents.Columns["DateOfBirth"].DisplayIndex = 3;
                    ToolStripStatusLabel1.Text = students.Count.ToString();
                    ToolStripStatusLabel2.Text = "Double click on GridRow to open detailscreen";
                    if (students.Count > 1) { ToolStripStatusLabel1.Text += " students found"; }
                    else { ToolStripStatusLabel1.Text += " student found"; }
                    ButtonDelete.Visible = true;
                }
                else
                {
                    GridViewStudents.Visible = false;
                    ToolStripStatusLabel1.Text = "No students found";
                    ToolStripStatusLabel2.Text = string.Empty;
                    ButtonDelete.Visible = false;
                }

            }
        }
    }
}

