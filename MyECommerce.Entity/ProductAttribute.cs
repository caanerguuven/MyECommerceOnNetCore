using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Entity
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public string ProductAttributeName { get; set; }
        public string ProductAttributeValue { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsActive { get; set; }
    }
}
