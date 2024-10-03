

using AppCode.BLL.BLLClasses;
using AppCode.BLL.Models;
using System.Windows.Forms;
using WinFormsSchool.Base;
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

            ButtonSearch.BackColor = Color.FromArgb(55, 150, 55);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 35;
            ButtonSearch.Image = Properties.Resources.SearchIcon;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft;

            DataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewUsers.Visible = false;
            DataGridViewUsers.ReadOnly = true;
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridViewUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);
            DataGridViewUsers.EnableHeadersVisualStyles = false;
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
            UserBLL user = new();
            users = user.GetUsers();
            if (users is not null)
            {
                users = users.Where(X => (X.UserName.ToLower()).Contains(TextboxSearch.Text.ToLower())).ToList();
            }

            if (users.Count > 0)
            {
                DataGridViewUsers.DataSource = null;
                DataGridViewUsers.DataSource = users;
                DataGridViewUsers.Visible = true;
            }
            else
            {
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
    }
}
