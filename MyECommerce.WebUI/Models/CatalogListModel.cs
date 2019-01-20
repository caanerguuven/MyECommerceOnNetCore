using MyECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class CatalogListModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
