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

            modelBuilder.Entity<Company_User>().HasOne(C => C.company).WithMany(e => e.Companies_Users).HasForeignKey(C => C.CompanyId);
            modelBuilder.Entity<Company_User>().HasOne(C => C.user).WithMany(e => e.Companies_Users).HasForeignKey(C => C.UserId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Company_User>? Companies_Users { get; set; }

    }
}
