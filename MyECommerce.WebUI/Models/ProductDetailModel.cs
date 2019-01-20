using MyECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> RelatedProducts { get; set; }
    }
}
