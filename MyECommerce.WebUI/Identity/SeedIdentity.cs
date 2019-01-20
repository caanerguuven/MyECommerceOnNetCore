using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Identity
{
    public static class SeedIdentity
    {
        public static async Task CreateIdentityUser(IServiceProvider service, IConfiguration configuration)
        {
            using (var serviceScope = service.CreateScope())
            {
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ECommerceUser>>();
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                var userName = configuration["Data:Admin:userName"];
                var email = configuration["Data:Admin:email"];
                var password = configuration["Data:Admin:password"];
                var role = configuration["Data:Admin:role"];

                if (await userManager.FindByNameAsync(userName) == null)
                {
                    if (await roleManager.FindByNameAsync(role) == null)
                    {
                        await roleManager.CreateAsync(new IdentityRole(role));
                    }
                    var createdUser = new ECommerceUser()
                    {
                        UserName = userName,
                        Email = email,
                        Name = "Caner",
                        SurName = "Güven",
                        IsActive = true
                    };

                    IdentityResult result = await userManager.CreateAsync(createdUser, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(createdUser, role);
                    }
                }
            }
        }
    }
}
