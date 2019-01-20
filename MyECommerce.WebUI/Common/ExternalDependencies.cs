using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyECommerce.Repository.Abstract;
using MyECommerce.Repository.Concrete.EntityFramework;
using MyECommerce.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Common
{
    public static class ExternalDependencies
    {
        public static void InstallDependencies(this IServiceCollection services) {
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<ICategoryRepository, EFCategoryRepository>();
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddTransient<IUnitOfWork, EFUnitOfWork>();

            services.AddIdentity<ECommerceUser, IdentityRole>().AddEntityFrameworkStores<ECommerceIdentityDbContext>().AddDefaultTokenProviders();
        }
    }
}
