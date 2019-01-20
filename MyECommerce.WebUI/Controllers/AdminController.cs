using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyECommerce.Entity;
using MyECommerce.Repository.Abstract;
using MyECommerce.WebUI.Models;

namespace MyECommerce.WebUI.Controllers
{
    [Authorize(Roles = "adminECommerce")]
    public class AdminController : Controller
    {
        private IUnitOfWork repository;
        public AdminController(IUnitOfWork _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CatalogList()
        {
            var model = new CatalogListModel()
            {
                Categories = repository.Categories.GetAll().ToList(),
                Products = repository.Products.GetAll().ToList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category model)
        {

            if (ModelState.IsValid)
            {
                model.IsActive = true;
                repository.Categories.Add(model);
                repository.SaveChanges();

                return Ok(model);
            }

            return BadRequest();
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            AdminEditCategoryModel model = repository.Categories
                        .GetAll()
                        .Include(x => x.ProductCategories)
                        .ThenInclude(x => x.Product)
                        .Where(x => x.CategoryId == id)
                        .Select(s => new AdminEditCategoryModel()
                        {
                            CategoryId = s.CategoryId,
                            CategoryName = s.CategoryName,
                            IsActive =s.IsActive,
                            Products = s.ProductCategories
                                       .Select(ss => new AdminEditCategoryProductModel()
                                       {
                                           ProductId = ss.ProductId,
                                           ProductName = ss.Product.ProductName,
                                           ProductImageUrl = ss.Product.ProductImageUrl,
                                           IsApproved = ss.Product.IsApproved,
                                           IsFeatured = ss.Product.IsFeatured,
                                           IsHome = ss.Product.IsHome
                                       }).ToList()
                        }).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public IActionResult EditCategory(Category model)
        {
            if (ModelState.IsValid)
            {
                repository.Categories.Update(model);
                repository.SaveChanges();
                return RedirectToAction("CatalogList");
            }
            return View("Error");
        }

        public IActionResult DeleteCategory(int id)
        {

            Category model = repository.Categories.Find(x => x.CategoryId == id).FirstOrDefault();
            if (model != null)
            {
                repository.Categories.Delete(model);
                repository.SaveChanges();
            }
            return RedirectToAction("CatalogList");
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images//products//", file.FileName);
                    var thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images//products//thumbs", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        model.ProductImageUrl = file.FileName;
                    }

                    using (var streamthumb = new FileStream(thumbPath, FileMode.Create))
                    {
                        await file.CopyToAsync(streamthumb);
                    }
                }
                model.CreatedDate = DateTime.Now;
                model.IsActive = true;
                repository.Products.Add(model);
                repository.SaveChanges();
                return RedirectToAction("CatalogList");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            Product model = repository.Products.Find(x => x.ProductId == id).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(Product model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\products\", file.FileName);
                    var thumbPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\products\thumbs\", file.FileName);

                    if (!System.IO.File.Exists(path))
                    {
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }

                    if (!System.IO.File.Exists(thumbPath))
                    {
                        using (var streamthumb = new FileStream(thumbPath, FileMode.Create))
                        {
                            await file.CopyToAsync(streamthumb);
                        }
                    }

                    model.ProductImageUrl = file.FileName;
                }

                repository.Products.Update(model);
                repository.SaveChanges();
                return RedirectToAction("CatalogList");
            }
            return View(model);
        }

        public IActionResult DeleteProduct(int id)
        {
            Product model = repository.Products.Find(x => x.ProductId == id).FirstOrDefault();
            if (model!=null)
            {
                repository.Products.Delete(model);
                repository.SaveChanges();
            }
            return RedirectToAction("CatalogList");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveCategoryProduct(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                repository.ProductCategories.Delete(model);
                repository.SaveChanges();

                return Ok(model);
            }

            return BadRequest();
        }
    }
}