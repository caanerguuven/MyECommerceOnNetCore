using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Entity
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ProductImageName { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsActive { get; set; }
    }
}
