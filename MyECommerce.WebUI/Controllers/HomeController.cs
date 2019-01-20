using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyECommerce.Repository.Abstract;
using MyECommerce.WebUI.Models;

namespace MyECommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public int pageSize = 3;
        private IUnitOfWork unitOfWork;
        public HomeController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            var productList = unitOfWork.Products.GetAll().Where(x => x.IsActive == true && x.IsApproved == true && x.IsHome == true).ToList();
            var model = new ProductPageModel()
            {
                Products = productList,
                PageModel = new PagingInfoModel()
                {
                    CurrentPage = 1,
                    ItemsPerPage = pageSize,
                    TotalItems = productList.Count
                }
            };
            return View(model);
        }
        public IActionResult Detail(int id) {
            return View(unitOfWork.Products.Get(id));
        }
    }
}