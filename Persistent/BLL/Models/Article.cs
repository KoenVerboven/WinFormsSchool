
namespace AppCode.BLL.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public int ArtcileCategory { get; set; }
        public decimal? ArticlePrice { get; set; }
        public int? NumberInStock { get; set; }
        public int? MinStock { get; set; }
        public int? NumberSoldInTotal { get; set;}
        public int? QuantityInPackage { get; set; }
        public decimal? ArticleWeightInKg { get; set; }
        public bool Fragile { get; set; }
        public int? ArticleHeightInCM { get; set; }
        public int? ArticleWidthInCM { get; set; }
        public int? ArticleDephInCM { get; set; }
        public string? ArticleSize { get => ArticleSizeMethod(); }
        public string? Message { get; set; }
        public string? ArticlePicture { get; set; }

        private string? ArticleSizeMethod()
        {
            if(ArticleHeightInCM is not null && ArticleWidthInCM is not null && ArticleDephInCM is not null)
            {
                return ArticleHeightInCM + " x " + ArticleWidthInCM + " x " + ArticleDephInCM;
            }
            else { return null;  }
        }

    }
}
