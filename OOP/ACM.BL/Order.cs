using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {

        public Order()
        {
            
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OderItems = new List<OrderItem>();
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if(OrderDate == null) isValid = false;
            return isValid;
        }

    }
}