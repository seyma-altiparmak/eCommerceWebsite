using eCommerceWebsite.Data;
using System.ComponentModel.DataAnnotations;

namespace eCommerceWebsite.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
