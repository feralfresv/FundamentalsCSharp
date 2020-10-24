using System;
using Xunit;

namespace Testability.UnitTest
{
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [Fact]
        
        public void Process_OrderIsAlreadyShipped_ThrowsANException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            //orderProcessor.Process(order);
            Assert.Throws<ArgumentException>(() => orderProcessor.Process(order));

        }
        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculatedShipping(Order order)
            {
                return 1;
            }
        }
    }
}
