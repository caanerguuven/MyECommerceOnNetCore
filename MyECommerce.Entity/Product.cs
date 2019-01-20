using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyECommerce.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public string Description { get; set; }
        public string HtmlContent { get; set; }
        public bool IsApproved { get; set; }
        public bool IsFeatured { get; set; } 
        public bool IsHome { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
