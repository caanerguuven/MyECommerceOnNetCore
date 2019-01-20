using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyECommerce.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public bool IsActive { get; set; }
    }
}
