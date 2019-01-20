using MyECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.WebUI.Models
{
    public class CartModel
    {
        private List<CartLineModel> _products = new List<CartLineModel>();
        public List<CartLineModel> products {
            get {
                return _products;
            }
        }

        public void AddProduct(Product product, int quantity) {
            var productExists = _products.Where(x => x.Product.ProductId == product.ProductId).FirstOrDefault();
            if (productExists==null)
            {
                _products.Add(new CartLineModel() { Product = product, Quantity = quantity });
            }
            else
            {
                productExists.Quantity += quantity;
            }
        }

        public void RemoveProduct(Product product)
        {
            _products.RemoveAll(x => x.Product.ProductId == product.ProductId);
        }

        public void ClearAllProduct() {
            _products.Clear();
        }
        public double TotalPriceOfProducts() {
            return _products.Sum(x => x.Product.ProductPrice * x.Quantity);
        }
    }
}
