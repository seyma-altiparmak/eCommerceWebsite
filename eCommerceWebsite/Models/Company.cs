using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerceWebsite.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set;}
        public List<Product> products { get; set; }
    }
    }
