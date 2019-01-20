using MyECommerce.Entity;
using MyECommerce.Entity.Model;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public class EFCategoryRepository : EFGenericRepository<Category>, ICategoryRepository
    {
        public EFCategoryRepository(MyECommerceContext context):base(context)
        {

        }

        public MyECommerceContext MyECommerceContext {
            get
            {
                return context as MyECommerceContext;
            }
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return MyECommerceContext.Categories.Where(x => x.IsActive == true).Select(s => new CategoryModel
            {
                CategoryId = s.CategoryId,
                CategoryName = s.CategoryName,
                CategoryCount = s.ProductCategories.Count
            });
        }

        public Category GetCategoryByName(string name)
        {
            
            return MyECommerceContext.Categories.FirstOrDefault(x => x.IsActive == true && x.CategoryName == name.Trim());
        }
    }
}
