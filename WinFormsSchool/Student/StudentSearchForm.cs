using AppCode.BLL.BLLClasses;
using AppCode.BLL.GeneralClasses;
using AppCode.BLL.Models;
using System.Data;
using WinFormsSchool.GeneralForms;


namespace WinFormsSchool
{
    public partial class StudentSearchForm : Base.BaseForm1
    {
        readonly StudentBLL Student;
        List<Student> students;

        public StudentSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            Student = new StudentBLL();
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;
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
            ButtonInsertNewStudent.Image = Properties.Resources.add2;
            ButtonInsertNewStudent.FlatStyle = FlatStyle.Flat;
            ButtonInsertNewStudent.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonInsertNewStudent.Text = string.Empty;

            ButtonUpdateStudent.BackColor = Color.White;
            ButtonUpdateStudent.Height = 45;
            ButtonUpdateStudent.Width = 45;
            ButtonUpdateStudent.FlatStyle = FlatStyle.Flat;
            ButtonUpdateStudent.Visible = false;

            ButtonDelete.BackColor = Color.White;
            ButtonDelete.Height = 45;
            ButtonDelete.Width = 45;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Visible = false;

            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            LabelPageTitle.Text = "Search Student";

            var ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.ButtonSearch, "Search");
            var ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.ButtonClose, "Close this page");
            var ToolTip3 = new ToolTip();
            ToolTip3.SetToolTip(this.ButtonInsertNewStudent, "Add new student");
            var ToolTip4 = new ToolTip();
            ToolTip4.SetToolTip(this.ButtonUpdateStudent, "Update Student");
            var ToolTip5 = new ToolTip();
            ToolTip5.SetToolTip(this.ButtonDelete, "Delete Student");
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

        private void FilterStudents()
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

                if (students.Count > 0)
                {
                    FillGridView();
                }
                else
                {
                    GridViewStudents.Visible = false;
                    ToolStripStatusLabel1.Text = "No students found";
                    ToolStripStatusLabel2.Text = string.Empty;
                    ButtonUpdateStudent.Visible = false;
                    ButtonDelete.Visible = false;
                }

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

                                var studentBLL = new StudentBLL();
                                var ok = false;
                                ok = studentBLL.DeleteStudent(itemRemove.PersonId);
                                if (ok) FilterStudents();
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
                var personId = "";
                if (GridViewStudents.SelectedRows[0].Cells["PersonId"].Value is not null)
                {
                    personId = GridViewStudents.SelectedRows[0].Cells["PersonId"].Value.ToString();
                }

                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "Form", "StudentSearchForm" },
                  { "Method", "ButtonDelete_Click" },
                  { "selectedArticleId", personId }
                };
                var logError = new LogError();
                LogError.LogException(oEx, dictErrorData);

                ShowErrorMessage();
            }
        }

        private static void ShowErrorMessage()
        {
            CustomErrorForm customErrorForm = new(
                             new("An error occurred. Please try again later.", "", "", "", false, null, DateTime.Now)
                                                 );
            customErrorForm.ShowDialog();
        }

        private void FillGridView()
        {

            GridViewStudents.DataSource = students;

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
            ButtonUpdateStudent.Visible = true;


        }

        private void ButtonInsertNewStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new(DetailFormType.InsertForm)
            {
                MdiParent = MdiParent
            };
            studentForm.Show();
        }

        private void ButtonUpdateStudent_Click(object sender, EventArgs e)
        {
            var succes = int.TryParse(GridViewStudents.SelectedRows[0].Cells["PersonId"].Value.ToString(), out int selectedId);
            if (succes)
            {
                StudentForm studentForm = new(DetailFormType.UpdateForm)
                {
                    MdiParent = MdiParent
                };
                studentForm.LoadSelectedStudent(selectedId);
                studentForm.Show();
            }
        }

        private void ButtonSearch_Click_1(object sender, EventArgs e)
        {
            const int MinimumCharactersSearchCommand = 1;

            if (TextboxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                FilterStudents();
            }
            else
            {
                ToolStripStatusLabel1.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                GridViewStudents.Visible = false;
                ButtonUpdateStudent.Visible = false;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (GridViewStudents.Visible)
            {
                var result = MessageBox.Show("Are you sure closing the Student Search Form? You loosing the search results.", "closing",
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
    
    }
}

