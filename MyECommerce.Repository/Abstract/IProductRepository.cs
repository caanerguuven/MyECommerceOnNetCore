using MyECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyECommerce.Repository.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetTop5Product();
    }
}
