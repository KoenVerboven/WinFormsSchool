using AppCode.BLL.BLLClasses;
using System.Data;


namespace WinFormsSchool
{
    public partial class SchoolArticleSearchForm : Form
    {
        readonly ArticleBLL SchoolArticle;

        public SchoolArticleSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            GridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolArticle = new ArticleBLL();
        }

        private void InitializeControls()
        {
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel2.Text = string.Empty;
            GridViewArticles.ReadOnly = true;
            ButtonSearch.BackColor = Color.FromArgb(55, 55, 55);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 35;
        }

        private void ButtonGetAllArticles_Click(object sender, EventArgs e) 
        {
            var searchArticles = SchoolArticle.GetArticles();
            _ = int.TryParse(TextboxSearch.Text, out int articleId);

            if(searchArticles != null)
            {
                searchArticles = searchArticles
                          .Where(X => (X.ArticleName.ToLower()).Contains(TextboxSearch.Text.ToLower())
                                   || (X.ArticleId == articleId)
                                   ).ToList();

                if (searchArticles.Count > 0)
                {
                    GridViewArticles.DataSource = searchArticles;
                    ToolStripStatusLabel1.Text = "Double click on GridRow to open detailscreen";
                }
                else
                {
                    GridViewArticles.Visible = false;
                    ToolStripStatusLabel1.Text = "No Articles found";
                    ToolStripStatusLabel2.Text = string.Empty;
                }

            }
          
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success = int.TryParse(GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString(),out int selectedId);
            
            if (success) {
                SchoolArticleForm schoolArticleForm = new();
                schoolArticleForm.MdiParent = MdiParent;
                schoolArticleForm.LoadSelectedArticle(selectedId);
                schoolArticleForm.Show();
            }

        }
    }
}
