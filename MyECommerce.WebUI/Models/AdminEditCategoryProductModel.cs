﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class AdminEditCategoryProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public bool IsFeatured { get; set; }
    }
}
