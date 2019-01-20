using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Entity
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
    }
}
