using Microsoft.EntityFrameworkCore;
using System;
namespace eCommerceWebsite.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }
    }
}
