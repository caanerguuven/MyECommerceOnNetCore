using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly MyECommerceContext context;
        public EFUnitOfWork(MyECommerceContext _context)
        {
            context = _context??throw new ArgumentNullException("Context can not be null");
        }

        private ICategoryRepository _categories;

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EFCategoryRepository(context));
            }
        }

        private IProductRepository _products;
        public IProductRepository Products {
            get {
                return _products ?? (_products = new EFProductRepository(context));
            }
        }

        private IOrderRepository _orders;
        public IOrderRepository Orders {
            get {
                return _orders ??  (_orders = new EFOrderRepository(context));
            }
        }

        private IProductCategoryRepository _productCategories;
        public IProductCategoryRepository ProductCategories {
            get {
                return _productCategories ?? (_productCategories = new EFProductCategoryRepository(context));
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
