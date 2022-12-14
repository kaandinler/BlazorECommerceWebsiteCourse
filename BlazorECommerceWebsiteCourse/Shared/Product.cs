using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorECommerceWebsiteCourse.Shared
{
    public class Product
    {
        public int id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
    }
}
