using eCommerceWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace eCommerceWebsite.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company_User>().HasKey(e => new
            {
                e.UserId,
                e.CompanyId
            } );

            modelBuilder.Entity<Company_User>().HasOne(C => C.company).WithMany(e => e.Companies_Users).HasForeignKey(C => C.UserId);
            //13-11

            base.OnModelCreating(modelBuilder);
        }
    }
}
