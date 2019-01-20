using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyECommerce.Repository.Concrete.EntityFramework;
using MyECommerce.WebUI.Common;
using MyECommerce.WebUI.Identity;

namespace MyECommerce.WebUI
{
    public class Startup
    {
        private IConfiguration configuration;
        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyECommerceContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyECommerceDbConnection"),b=> b.MigrationsAssembly("MyECommerce.WebUI")));
            services.AddDbContext<ECommerceIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyECommerceIdentityDbConnection")));
            services.InstallDependencies();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseSession();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                                name:"searchByCategories",
                                template:"Product/{categoryName?}",
                                defaults:new { controller ="Product",action="List" }
                );

                routes.MapRoute(
                                 name: "myDefaultRoute",
                                 template: "{controller=Home}/{action=Index}/{id?}"
                               );
            });


            SeedData.EnsurePopulated(app);
            SeedIdentity.CreateIdentityUser(app.ApplicationServices, configuration).Wait();
        }
    }
}
