using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveOrderDisplayTest()
        {
            //arrange
            var oder = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, 
                                                                new TimeSpan(7, 0, 0))
            };
            var orderRepository = new OrderRepository();

            //action
            var result = orderRepository.Retrieve(10);

            //assert
            Assert.Equal(oder.OrderDate, result.OrderDate);

        }
    }
}