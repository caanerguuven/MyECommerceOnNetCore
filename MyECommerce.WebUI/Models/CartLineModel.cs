using MyECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class CartLineModel
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
