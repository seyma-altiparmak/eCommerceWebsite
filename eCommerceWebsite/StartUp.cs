using eCommerceWebsite.Data;
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
            services.AddDbContext<AppDBContext>(options -> options.UseSqlServer(Configuration.
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
