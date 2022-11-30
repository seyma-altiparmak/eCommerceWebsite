using eCommerceWebsite.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceWebsite.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public DateTime Sale_StartDate { get; set; }
        public DateTime Sale_EndDate { get; set; }
        public ProductCategory ProductCategory { get; set; }

        //Relationship
        public List<Company_User>? Companies_Users { get; set; }

        //User
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User? user { get; set; }

    }
}
