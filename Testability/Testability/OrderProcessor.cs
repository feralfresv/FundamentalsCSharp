using System;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippinCalculator;
        public OrderProcessor(IShippingCalculator shippinCalculator)
        {
            _shippinCalculator = shippinCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new ArgumentException("This order already processed");

            order.Shipment = new Shipment
            {
                Cost = _shippinCalculator.CalculatedShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
