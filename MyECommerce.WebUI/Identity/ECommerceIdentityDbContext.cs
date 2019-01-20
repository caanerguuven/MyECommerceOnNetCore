using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Identity
{
    public class ECommerceIdentityDbContext:IdentityDbContext<ECommerceUser>
    {
        public ECommerceIdentityDbContext(DbContextOptions<ECommerceIdentityDbContext> options):base(options)
        {

        }
    }
}
