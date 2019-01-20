using Microsoft.EntityFrameworkCore;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public class EFGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext context;
        public EFGenericRepository(DbContext _context)
        {
            context = _context;
        }
     
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            //context.Set<T>().Update(entity);
            context.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
