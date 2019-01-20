using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyECommerce.Repository.Abstract;

namespace MyECommerce.WebUI.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private IUnitOfWork unitOfWork;
        public CategoryController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            return View(unitOfWork.Categories.GetCategoryByName("Sample"));
        }
    }
}