using Microsoft.AspNetCore.Mvc;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Components
{
    public class FeaturedProducts:ViewComponent
    {
        private IProductRepository productRepository;
        public FeaturedProducts(IProductRepository _productRepository) {
            productRepository = _productRepository;
        }

        public IViewComponentResult Invoke() {
            var list = productRepository.GetAll().Where(x => x.IsActive && x.IsFeatured).ToList();
            return View(list);
        }
    }
}
