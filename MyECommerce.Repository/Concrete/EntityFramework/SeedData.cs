using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app) {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MyECommerceContext>();
                context.Database.Migrate();
            }

        }
    }
}
