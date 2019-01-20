using MyECommerce.Entity;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public class EFProductCategoryRepository:EFGenericRepository<ProductCategory>,IProductCategoryRepository
    {
        public EFProductCategoryRepository(MyECommerceContext context):base(context) {

        }
    }
}
