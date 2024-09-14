using AppCode.BLL.Models;

namespace AppCode.BLL.Interfaces
{
    public interface IArticleBLL
    {
        public Article? GetArticleById(int ArticleId);

        public List<Article>? GetArticles();

        public bool AddArticle();

        public bool UpdateArticle(Article Article);

        public bool DeleteArticle(int ArticleId);
    }
}
