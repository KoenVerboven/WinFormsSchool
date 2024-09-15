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
            GridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolArticle = new ArticleBLL();
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

                GridViewArticles.DataSource = searchArticles;
            }
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success = int.TryParse(GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString(),out int selectedId);
            
            if (success) {
                SchoolArticleForm schoolArticleForm = new();
                schoolArticleForm.LoadSelectedArticle(selectedId);
                schoolArticleForm.ShowDialog(this);
            }

        }
    }
}
