using MyECommerce.Entity;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyECommerce.Repository.Concrete.AdoNet
{
    public class AdoProductRepository :IProductRepository
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop5Product()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
