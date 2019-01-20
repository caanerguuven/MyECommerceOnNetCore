using MyECommerce.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyECommerce.Entity
{
    public class Order
    {

        public Order() {
            OrderDetails = new List<OrderDetail>();
        }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }
        public string OrderUserName { get; set; }
        public string OrderAddressHeader { get; set; }
        public string OrderAddressRow { get; set; }
        public string OrderCity { get; set; }
        public string OrderNeighborhood { get; set; }
        public string OrderTelephone { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public bool IsActive { get; set; }

        
    }
}
