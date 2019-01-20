using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyECommerce.Entity;
using MyECommerce.Repository.Abstract;
using MyECommerce.WebUI.Infrastructure;
using MyECommerce.WebUI.Models;

namespace MyECommerce.WebUI.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private IUnitOfWork repository;
        public CartController(IUnitOfWork _repository) {
            repository = _repository;
        }

        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult AddToCart(int productId, int quantity=1) {
            var _product = repository.Products.Get(productId);
            if (_product!=null)
            {
                var cart = GetCart();
                cart.AddProduct(_product, quantity);
                SaveToCard(cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var _product = repository.Products.Get(productId);
            if (_product != null)
            {
                var cart = GetCart();
                cart.RemoveProduct(_product);
                SaveToCard(cart);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(OrderDetailsModel model)
        {
            
            var _cart = GetCart();
            if (_cart.products.Count==0)
            {
                ModelState.AddModelError("NoProduct", "There are no products in your basket. ");
            }

            if (ModelState.IsValid)
            {
                SaveOrder(_cart,model);
                _cart.ClearAllProduct();
                SaveToCard(_cart);
                return View("CompletedOrder");
            }
            else
            {
                ModelState.AddModelError("Incorrect Model", "The Whole fields are necessary. Please fill them. ");
            }
           

            return View(model);
        }

        public void SaveOrder(CartModel cart, OrderDetailsModel model) {

            Order _order = new Order()
            {
                IsActive = true,
                OrderNumber = "ORD_" + (new Random()).Next(111, 555).ToString(),
                OrderTotal = cart.TotalPriceOfProducts(),
                OrderDate = DateTime.Now,
                OrderState = Entity.Enum.EnumOrderState.WaitingOrder,
                OrderUserName = User.Identity.Name,
                OrderAddressHeader = model.AddressHeader,
                OrderAddressRow = model.AddressRow,
                OrderCity = model.City,
                OrderNeighborhood = model.Neighborhood,
                OrderTelephone = model.Telephone,
            };

            foreach (var item in cart.products)
            {
                OrderDetail _orderDetail = new OrderDetail()
                {
                    IsActive = true,
                    ProductId = item.Product.ProductId,
                    Price = item.Product.ProductPrice,
                    Quantity = item.Quantity
                };

                _order.OrderDetails.Add(_orderDetail);
            }

            repository.Orders.Add(_order);
            repository.SaveChanges();

        }

        private void SaveToCard(CartModel cartModel)
        {
            HttpContext.Session.setJSON("Cart", cartModel);
        }

        private CartModel GetCart()
        {
            return (HttpContext.Session.getJSON<CartModel>("Cart") ?? new CartModel());
        }

        
    }
}