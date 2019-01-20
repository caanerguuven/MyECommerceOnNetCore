using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyECommerce.Entity;
using MyECommerce.Repository.Abstract;
using MyECommerce.WebUI.Models;

namespace MyECommerce.WebUI.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public int pageSize = 3;
        private IUnitOfWork uow;
        public ProductController(IUnitOfWork _uow) {
            uow = _uow;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string categoryName,int page = 1) {

            IQueryable<Product> products = null;

            if (!string.IsNullOrEmpty(categoryName))
            {
                products = uow.ProductCategories.GetAll()
                          .Where(x => x.Category.CategoryName.Contains(categoryName))
                          .Select(s => s.Product);

            }
            else
            {
                products = uow.Products.GetAll();
            }

            var productCount = products.Count();

            var productList = products
                      .Skip((page - 1) * pageSize)
                      .Take(pageSize)
                      .ToList();

            var model = new ProductPageModel()
            {
                Products = productList,
                PageModel = new PagingInfoModel()
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = productCount
                }
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var productCategoryIds = uow.ProductCategories.GetAll().Where(x => x.ProductId == id).Select(s => s.CategoryId).ToList();
            var relatedProducts = uow.ProductCategories.GetAll().Where(x => productCategoryIds.Contains(x.CategoryId) && x.ProductId != id).Select(s=> s.Product).ToList();

            ProductDetailModel productDetail = (uow.Products
                                       .GetAll()
                                       .Where(x => x.ProductId == id)
                                       .Include(x => x.ProductImages)
                                       .Include(x => x.ProductAttributes)
                                       .Include(x => x.ProductCategories).ThenInclude(xs => xs.Category)
                                       .Select(s => new ProductDetailModel()
                                       {
                                           Product = s,
                                           ProductImages = s.ProductImages,
                                           ProductAttributes = s.ProductAttributes,
                                           Categories = s.ProductCategories.Select(xs => xs.Category).ToList(),
                                           RelatedProducts = relatedProducts
                                       })).FirstOrDefault();
            return View(productDetail);
        }
    }
}