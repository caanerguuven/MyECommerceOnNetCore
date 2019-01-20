using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Identity
{
    public class ECommerceUser:IdentityUser
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public bool IsActive { get; set; }

    }
}
