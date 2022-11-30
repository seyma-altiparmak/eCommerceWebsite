namespace eCommerceWebsite.Models
{
    public class Company_User
    {
        public int CompanyId { get; set; }
        public Company company { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
    }
}
