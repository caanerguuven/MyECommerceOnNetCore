using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class AdminEditCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public List<AdminEditCategoryProductModel> Products { get; set; }
    }
}
