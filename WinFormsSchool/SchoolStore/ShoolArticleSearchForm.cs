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
            gridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolArticle = new ArticleBLL();
        }

        private void btnGetAllArticles_Click(object sender, EventArgs e) 
        {
            var searchArticles = SchoolArticle.GetArticles();
            _ = int.TryParse(textboxSearch.Text, out int articleId);

            if(searchArticles != null)
            {
                searchArticles = searchArticles
                          .Where(X => (X.ArticleName.ToLower()).Contains(textboxSearch.Text.ToLower())
                                   || (X.ArticleId == articleId)
                                   ).ToList();

                gridViewArticles.DataSource = searchArticles;
            }
          
        }


        private void btnDeleteArticle_Click(object sender, EventArgs e)
        {
            //AllArticles.Remove(1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success = int.TryParse(gridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString(),out int selectedId);
            
            if (success) {
                SchoolArticleForm schoolArticleForm = new();
                schoolArticleForm.LoadSelectedArticle(selectedId);
                schoolArticleForm.ShowDialog(this);
            }

        }
    }
}
