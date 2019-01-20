using Microsoft.AspNetCore.Mvc;
using MyECommerce.WebUI.Infrastructure;
using MyECommerce.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Components
{
    public class CartSummary:ViewComponent
    {
        public string Invoke() {
            string productCountInCart = HttpContext.Session.getJSON<CartModel>("Cart")?.products.Count.ToString() ?? "0";

            return productCountInCart;
        }
    }
}
