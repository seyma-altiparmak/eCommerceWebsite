using eCommerceWebsite.Data.Enums;
using eCommerceWebsite.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceWebsite.Data
{
    public class AppDInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //Company
                if (!context.Companies.Any())
                {
                    context.Companies.AddRange(new List<Company>());
                    {
                        new Company()
                        {
                            CompanyId = 1,
                            CompanyName = "DelavOR",
                            CompanyDescription = "Parfume",
                            CompanyEmail = "delavour@gmail.com",
                            CompanyPhone = "+1203202051"
                        };
                    }
                    context.SaveChanges();
                }
                //CompanyUser
                if (!context.Companies_Users.Any())
                {
                    context.Companies_Users.AddRange(new List<Company_User>());
                    {
                        new Company_User()
                        {

                        };
                    }
                    context.SaveChanges();
                }
                //Product
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>());
                    {
                        new Product()
                        {
                            ProductId = 5,
                            ProductName = "N203",
                            ProductDescription = "Vanilla and love",
                            Sale_StartDate = 01.01.2010,
                            Sale_EndDate = 02.05.2023,
                        };
                    }
                }
                //User
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>());
                    {
                        new User()
                        {
                        };
                    }
                }
            }
        } 
    } 
}
