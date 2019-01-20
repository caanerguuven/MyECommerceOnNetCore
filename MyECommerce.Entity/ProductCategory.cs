﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Entity
{
    public class ProductCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsActive { get; set; }
    }
}
