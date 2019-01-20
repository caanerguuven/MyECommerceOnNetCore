using Microsoft.AspNetCore.Mvc;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Components
{
    public class CategoryMenu:ViewComponent
    {
        private ICategoryRepository categoryRepository;

        public CategoryMenu(ICategoryRepository _categoryRepository) {
            categoryRepository = _categoryRepository;
        }

        public IViewComponentResult Invoke() {
            return View(categoryRepository.GetAllWithProductCount());
        }
    }
}
