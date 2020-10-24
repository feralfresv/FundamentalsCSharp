using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTest2
{
    [TestClass]
    public class OrderProcessorTests2
    {

        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Process_OrderIsAlreadyShipped_ThrowsANException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }

        
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
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
