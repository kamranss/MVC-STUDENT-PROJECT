using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;

namespace WebApplication1
{
    public class Startup
    {

        private readonly IConfiguration _config;

       

        public Startup(IConfiguration config)
        {
            _config = config;
        } 

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.addrazorpages();
            services.AddControllersWithViews();

            // connection to sql 
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
               /* options.UseSqlServer(_config["ConnectionString: DefaultConnection"]); */// another approach for accesing Sql connection path
                //"Server=.;Database=P515First;Trusted_Connection=True;MultipleActiveResultSets=true"
            });
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles(); // this method reads all static files like images css json files etc

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //  "default",
                //  "{controller}/{action}/{id?}"
                //);
                endpoints.MapControllerRoute(
                  "default",
                  "{controller=Home}/{action=Index}/{id?}"
                );

                //endpoints.MapRazorPages();
            });
        }
    }
}
