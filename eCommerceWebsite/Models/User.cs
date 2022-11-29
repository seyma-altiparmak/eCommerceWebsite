using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerceWebsite.Models
{
    public class User
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
