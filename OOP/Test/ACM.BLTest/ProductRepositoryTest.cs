using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveTest()
        {
            //arrange
            var productRepository = new ProductRepository();
            var product = new Product(2)
            {
                CurrentPrice = 15.69m,
                ProductDescription = "Descriptions...",
                ProductName = "Fernando"
            };

            //action
            var result = productRepository.Retrieve(2);

            //assert
            Assert.Equal(product.CurrentPrice, result.CurrentPrice);
            Assert.Equal(product.ProductDescription, result.ProductDescription);
            Assert.Equal(product.ProductName, result.ProductName);

        }
    }
}