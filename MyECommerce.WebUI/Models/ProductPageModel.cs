using MyECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class ProductPageModel
    {
        public List<Product> Products { get; set; }
        public PagingInfoModel PageModel { get; set; }
    }
}
