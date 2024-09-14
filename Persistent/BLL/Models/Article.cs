
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
        public bool? Fragile { get; set; }
        public int? ArticleHeightInMM { get; set; }
        public int? ArticleWidthInMM { get; set; }
        public int? ArticleDephInMM { get; set; }
        public string? Message { get; set; }
        public string? ArticlePicture { get; set; }
    }
}
