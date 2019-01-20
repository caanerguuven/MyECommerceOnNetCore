using MyECommerce.Entity;
using MyECommerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyECommerce.Repository.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Category GetCategoryByName(string name);
        IEnumerable<CategoryModel> GetAllWithProductCount(); 

    }
}
