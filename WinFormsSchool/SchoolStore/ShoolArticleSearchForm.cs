using AppCode.BLL.BLLClasses;
using AppCode.BLL.GeneralClasses;
using AppCode.BLL.Models;
using System.Data;
using WinFormsSchool.GeneralForms;

namespace WinFormsSchool
{
    public partial class SchoolArticleSearchForm : Base.BaseForm1
    {
        readonly ArticleBLL SchoolArticle;
        List<Article> articles;

        public SchoolArticleSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            GridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolArticle = new ArticleBLL();
        }

        private void InitializeControls()
        {
            WindowState = FormWindowState.Maximized;

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel2.Text = string.Empty;

            GridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewArticles.Visible = false;
            GridViewArticles.ReadOnly = true;
            GridViewArticles.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            GridViewArticles.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            GridViewArticles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GridViewArticles.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);
            GridViewArticles.EnableHeadersVisualStyles = false;

            splitContainer1.Panel2.Padding = new Padding(16);

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

            ButtonDelete.BackColor = Color.White;
            ButtonDelete.Height = 45;
            ButtonDelete.Width = 45;
            ButtonDelete.Image = Properties.Resources.delete1;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Visible = false;
            ButtonDelete.Text = string.Empty;

            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            LabelPageTitle.Text = "Search Article";
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
            label1.ForeColor = Color.White;

            var tooltip = new ToolTip();
            tooltip.SetToolTip(ButtonSearch, "Search");
            tooltip.SetToolTip(ButtonClose, "Close this page");
            tooltip.SetToolTip(ButtonDelete, "Delete article");
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


        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success = int.TryParse(GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString(), out int selectedId);

            if (success)
            {
                SchoolArticleForm schoolArticleForm = new()
                {
                    MdiParent = MdiParent
                };
                schoolArticleForm.LoadSelectedArticle(selectedId);
                schoolArticleForm.Show();
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure delete the selected article "
                                             + GridViewArticles.SelectedRows[0].Cells["ArticleName"].Value.ToString() + " ?"
                                             , "Delete article",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    var success = int.TryParse(GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString(), out int selectedId);
                    if (success)
                    {
                        var itemRemove = articles.Single(r => r.ArticleId == selectedId);

                        if (itemRemove != null)
                        {
                            articles.Remove(itemRemove);
                        }

                        FillGridView();
                    }
                }

            }
            catch (Exception oEx)
            {
                var articleId = "";
                if (GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value is not null)
                {
                    articleId = GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString();
                }

                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "Form", "SchoolArticleSearchForm" },
                  { "Method", "ButtonDelete_Click" },
                  { "selectedArticleId", articleId }
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
            if (articles.Count > 0)
            {
                GridViewArticles.DataSource = null;
                GridViewArticles.DataSource = articles;
                GridViewArticles.Visible = true;
                ToolStripStatusLabel1.Text = "Double click on GridRow to open detailscreen";
                ButtonDelete.Visible = true;
            }
            else
            {
                GridViewArticles.Visible = false;
                ToolStripStatusLabel1.Text = "No Articles found";
                ToolStripStatusLabel2.Text = string.Empty;
                ButtonDelete.Visible = false;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            articles = SchoolArticle.GetArticles();
            _ = int.TryParse(TextboxSearch.Text, out int articleId);

            if (articles != null)
            {
                articles = articles
                          .Where(X => (X.ArticleName.ToLower()).Contains(TextboxSearch.Text.ToLower())
                                   || (X.ArticleId == articleId)
                                   ).ToList();

                FillGridView();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


