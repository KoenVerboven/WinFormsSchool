

using AppCode.BLL.BLLClasses;
using AppCode.BLL.GeneralClasses;
using AppCode.BLL.Models;
using System.Windows.Forms;
using WinFormsSchool.Base;
using WinFormsSchool.GeneralForms;
using WinFormsSchool.UserForms;

namespace WinFormsSchool
{
    public partial class UserSearchForm : BaseForm1
    {

        List<User> users;
        public UserSearchForm()
        {
            InitializeComponent();
            InitializeControls();

        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;
            LabelPageTitle.Text = "Search User";
            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            DataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewUsers.Visible = false;
            DataGridViewUsers.ReadOnly = true;
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);
            DataGridViewUsers.EnableHeadersVisualStyles = false;

            ButtonSearch.BackColor = Color.FromArgb(190, 190, 190);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 27;
            ButtonSearch.Width = 29;
            ButtonSearch.Image = Properties.Resources.search1;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonClose.BackColor = Color.White;
            ButtonClose.Height = 45;
            ButtonClose.Width = 45;
            ButtonClose.Image = Properties.Resources.Close4;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonClose.Text = string.Empty;


            ButtonInsertNewUser.BackColor = Color.White;
            ButtonInsertNewUser.Height = 45;
            ButtonInsertNewUser.Width = 45;
            ButtonInsertNewUser.Image = Properties.Resources.Plus1;
            ButtonInsertNewUser.FlatStyle = FlatStyle.Flat;
            ButtonInsertNewUser.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonInsertNewUser.Text = string.Empty;

            ButtonUpdateUser.BackColor = Color.White;
            ButtonUpdateUser.Height = 45;
            ButtonUpdateUser.Width = 45;
            ButtonUpdateUser.Image = Properties.Resources.edit1;
            ButtonUpdateUser.FlatStyle = FlatStyle.Flat;
            ButtonUpdateUser.Visible = false;
            ButtonUpdateUser.Text = string.Empty;

            ButtonDelete.BackColor = Color.White;
            ButtonDelete.Height = 45;
            ButtonDelete.Width = 45;
            ButtonDelete.Image = Properties.Resources.delete1;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Visible = false;
            ButtonDelete.Text = string.Empty;

            var tooltip = new ToolTip();
            tooltip.SetToolTip(ButtonSearch, "Search");
            tooltip.SetToolTip(ButtonClose, "Close this page");
            tooltip.SetToolTip(ButtonInsertNewUser, "Add new User");
            tooltip.SetToolTip(ButtonUpdateUser, "Update User");
            tooltip.SetToolTip(ButtonDelete, "Delete User");

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


        private void ButtonSearch_Click_1(object sender, EventArgs e)
        {
            //UserBLL user = new();
            //users = user.GetUsers();
            //if (users is not null)
            //{
            //    users = users.Where(X => (X.UserName.ToLower()).Contains(TextboxSearch.Text.ToLower())).ToList();
            //}

            //if (users.Count > 0)
            //{
            //    DataGridViewUsers.DataSource = null;
            //    DataGridViewUsers.DataSource = users;
            //    DataGridViewUsers.Visible = true;
            //}
            //else
            //{
            //    DataGridViewUsers.Visible = false;
            //}


            const int MinimumCharactersSearchCommand = 1;

            if (TextboxSearch.Text.Length >= MinimumCharactersSearchCommand)
            {
                FilterUsers();
            }
            else
            {
                // ToolStripStatusLabel1.Text = "Search text must contain at least " + MinimumCharactersSearchCommand + "Character(s).";
                DataGridViewUsers.Visible = false;
            }
        }

        private void DataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var succes = int.TryParse(DataGridViewUsers.SelectedRows[0].Cells["UserId"].Value.ToString(), out int selectedId);
            if (succes)
            {
                UserForm userForm = new(DetailFormType.ShowDetailForm)
                {
                    MdiParent = MdiParent
                };
                userForm.LoadSelectedUser(selectedId);
                userForm.Show();
            }
        }

        private void ButtonInsertNewUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new(DetailFormType.InsertForm)
            {
                MdiParent = MdiParent
            };
            userForm.Show();
        }

        private void ButtonUpdateUser_Click(object sender, EventArgs e)
        {
            var succes = int.TryParse(DataGridViewUsers.SelectedRows[0].Cells["UserId"].Value.ToString(), out int selectedId);
            if (succes)
            {
                UserForm userForm = new(DetailFormType.UpdateForm)
                {
                    MdiParent = MdiParent
                };
                userForm.LoadSelectedUser(selectedId);
                userForm.Show();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure delete the selected user "
                                             + DataGridViewUsers.SelectedRows[0].Cells["UserName"].Value.ToString() + " ?"
                                             , "Delete User",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    var success = int.TryParse(DataGridViewUsers.SelectedRows[0].Cells["UserId"].Value.ToString(), out int selectedId);
                    if (success)
                    {
                        var itemRemove = users.Single(r => r.UserId == selectedId);

                        if (itemRemove != null)
                        {
                            var userBLL = new UserBLL();
                            var ok = false;
                            ok = userBLL.DeleteUser(itemRemove.UserId);
                            if (ok) FilterUsers();
                        }

                        //FillGridView();
                    }
                }
            }
            catch (Exception oEx)
            {
                var personId = "";
                if (DataGridViewUsers.SelectedRows[0].Cells["UserId"].Value is not null)
                {
                    personId = DataGridViewUsers.SelectedRows[0].Cells["UserId"].Value.ToString();
                }

                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "Form", "UserSearchForm" },
                  { "Method", "ButtonDelete_Click" },
                };
                var logError = new LogError();
                LogError.LogException(oEx, dictErrorData);

                ShowErrorMessage();
            }
        }

        private void FillGridView()
        {
            if (users.Count > 0)
            {
                DataGridViewUsers.DataSource = users;
                if (users.Count > 0)
                {
                    DataGridViewUsers.DataSource = null;
                    DataGridViewUsers.DataSource = users;
                    DataGridViewUsers.Visible = true;
                    ButtonDelete.Visible = true;
                    ButtonUpdateUser.Visible = true;
                }
                else
                {
                    DataGridViewUsers.Visible = false;
                    ButtonDelete.Visible = false;
                }
            }
        }



        private void FilterUsers()
        {
            _ = int.TryParse(TextboxSearch.Text, out int personId);

            UserBLL user = new();
            users = user.GetUsers();
            if (users is not null)
            {
                users = users.Where(X => (X.UserName.ToLower()).Contains(TextboxSearch.Text.ToLower())).ToList();

                FillGridView();
            }

        }


        private static void ShowErrorMessage()
        {
            CustomErrorForm customErrorForm = new(
                             new("An error occurred. Please try again later.", "", "", "", false, null, DateTime.Now)
                                                 );
            customErrorForm.ShowDialog();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if(DataGridViewUsers.Visible)
            {
                var result = MessageBox.Show("Are you sure closing the User Search Form? You loosing the search results.", "closing",
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
