using MyECommerce.Entity;
using MyECommerce.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyECommerce.Repository.Concrete.EntityFramework
{
    public class EFOrderRepository : EFGenericRepository<Order>,IOrderRepository
    {
        public EFOrderRepository(MyECommerceContext context) : base(context)
        {

        }
      
    }
}
