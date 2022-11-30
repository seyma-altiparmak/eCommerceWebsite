using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerceWebsite.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        public List<Product>? product { get; set; }
        public List<Company_User>? Companies_Users { get; set; }
    }
}
