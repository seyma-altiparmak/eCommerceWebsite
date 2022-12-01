using eCommerceWebsite.Data;
using Microsoft.Extensions.Options;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace eCommerceWebsite
{
    public class StartUp
    {
        public StartUp(IConfiguration configuration) {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            IServiceCollection serviceCollection = services.AddDbContext<AppDBContext>(Options -> options.UseSqlServer(Configuration.
            GetConnectionString("DefaultConnectionString")));
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app,
                              IWebHostEnvironment env)
        {
            if (env is null)
            {
                throw new ArgumentNullException(nameof(env));
            }

            if (env.IsDevelopment()) { }
        }
    }
}
