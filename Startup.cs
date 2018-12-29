using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Cosmetology.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Cosmetology
{
    public class Startup
    {
   /*      public Startup(IHostingEnvironment environment)
        {
            var builder=new ConfigurationBuilder().SetBasePath(environment.ContentRootPath).AddJsonFile("Settings.json");
            Configuration=builder.Build();
        }
        
*/
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get;set;}

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            var s=Configuration.GetConnectionString("Connection");
            services.AddDbContext<ModelsDBContext>(options=>options.UseSqlite(Configuration.GetConnectionString("Connection")));
            services.AddEntityFrameworkSqlite().AddDbContext<ModelsDBContext>();
            services.AddIdentity<Users,IdentityRole>().AddEntityFrameworkStores<ModelsDBContext>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
           
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
