using MyECommerce.Entity;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public class EFProductRepository : EFGenericRepository<Product>, IProductRepository
    {
        public EFProductRepository(MyECommerceContext context):base(context) {

        }

        public MyECommerceContext MyECommerceContext {
            get
            {
                return context as MyECommerceContext;
            }
        }
        public List<Product> GetTop5Product()
        {
            return MyECommerceContext.Products.Where(x => x.IsActive == true).OrderByDescending(x => x.ProductId).Take(5).ToList();
        }
    }

}

