using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        IProductCategoryRepository ProductCategories { get; }
        IOrderRepository Orders { get; }

        int SaveChanges();
    }
}
