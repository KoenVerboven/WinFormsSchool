using AppCode.BLL.Interfaces;
using AppCode.BLL.Models;

namespace AppCode.BLL.BLLClasses
{
    public class ArticleBLL : IArticleBLL //a student can bye schoolartikels like books, laptop, ...
    {
        List<Article>? Articles;

        public ArticleBLL() // constructor : ctor
        {
            FillArticlesList();
        }

        public Article? GetArticleById(int ArticleId)
        {
            Article? article = null;
            if (ArticleId > -1 && Articles != null)
            {
                article = Articles.Single(p => p.ArticleId == ArticleId);
                article.Message = GetArticleMessage(article);
            }
            return article;
        }

        private static string GetArticleMessage(Article article)
        {
            var message = string.Empty;
            if (article.Fragile is not null)
            {
                if (Convert.ToBoolean(article.Fragile))
                {
                    message = "* Article is fragile, handle with care !!";
                }
            }
            if (article.NumberInStock < article.MinStock)
            {
                if (message != string.Empty) message += Environment.NewLine;
                message += "* Number in stock is less than Minimumstock !! Take action !!";
            }
            return message;
        }

        public List<Article>? GetArticles()
        {
            return Articles;
        }

        public bool DeleteArticle(int ArticleId)
        {
            return false;
        }

        public bool AddArticle()
        {
            throw new NotImplementedException();
        }

        public bool UpdateArticle(Article Article)
        {
            throw new NotImplementedException();
        }



        private void FillArticlesList()
        {
            Articles =
            [
                new()
                {
                    ArticleId = 1,
                    ArtcileCategory = 2,
                    ArticleName = "hp laptop",
                    ArticlePrice = 200.99m,
                    NumberInStock = 9,
                    MinStock = 10,
                    QuantityInPackage = 1,
                    ArticleWeightInKg = 1.5m,
                    Fragile = true
                },
                new()
                {
                    ArticleId = 2,
                    ArtcileCategory = 2,
                    ArticleName = "hp laptop",
                    ArticlePrice = 1999m,
                    NumberInStock = 30,
                    MinStock = 10,
                    QuantityInPackage = 1,
                    ArticleWeightInKg = 1.5m,
                    Fragile = true
                },
                new()
                {
                    ArticleId = 3,
                    ArtcileCategory = 3,
                    ArticleName = "Lenova laptop",
                    ArticlePrice = null
                },
                new()
                {
                    ArticleId = 4,
                    ArtcileCategory = 3,
                    ArticleName = "Apple laptop",
                    ArticlePrice = 155.50m
                },
                new()
                {
                    ArticleId = 5,
                    ArtcileCategory = 5,
                    ArticleName = "Bic balpen blew",
                    ArticlePrice = null,
                    NumberInStock = 500,
                    MinStock = 100,
                    QuantityInPackage = 10,
                    ArticleWeightInKg = 0.01m,
                    Fragile = false
                },
                new()
                {
                    ArticleId = 6,
                    ArtcileCategory = 5,
                    ArticleName = "Bic balpen red",
                    ArticlePrice = 2.50m,
                    NumberInStock = 901,
                    MinStock = 50,
                    QuantityInPackage = 10,
                    ArticleWeightInKg = 0.01m,//moet dit decimal zijn?
                    Fragile = false
                },
                new()
                {
                    ArticleId = 7,
                    ArtcileCategory = 5,
                    ArticleName = "logitec mouse",
                    ArticlePrice = 155.50m,
                    NumberInStock = 31,
                    MinStock = 10,
                    QuantityInPackage = 10,
                    ArticleWeightInKg = 0.1m,
                    Fragile = true
                },
                new()
                {
                    ArticleId = 8,
                    ArtcileCategory = 5,
                    ArticleName = "HP wireless mouse",
                    ArticlePrice = 29.99m
                },
                new()
                {
                    ArticleId = 9,
                    ArtcileCategory = 5,
                    ArticleName = "Blocknote 100 pages",
                    ArticlePrice = 10.99m
                },

            ];
        }

    }
}
