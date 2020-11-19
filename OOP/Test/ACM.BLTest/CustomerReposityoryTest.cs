using System;
using Xunit;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    public class CustomerReposityoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //arrange
            var customerReposityory = new CustomerRepository();
            var expect = new Customer(1)
            {
                EmailAddress = "fer@gmail.com",
                FirstName = "Fernando",
                LastName = "Sanchez"
            };

            //act
            var result = customerReposityory.Retrieve(1);

            //assert
            Assert.Equal(expect.CustomerId, result.CustomerId);
            Assert.Equal(expect.EmailAddress, result.EmailAddress);
            Assert.Equal(expect.FirstName, result.FirstName);
            Assert.Equal(expect.LastName, result.LastName);
        }

        [Fact]
        public void RetrieveExistingWithAdress()
        {
            var customer = new Customer(1)
            {
                EmailAddress = "fer@gmail.com",
                FirstName = "Fernando",
                LastName = "Sanchez",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddresType = 1,
                        StreetLine1 = "St1",
                        StreetLine2 = "St2",
                        City = "Merida",
                        State = "Yucatan",
                        Country = "Mexico",
                        PostalCode = "97133"
                    },
                    new Address()
                    {
                        AddresType = 2,
                        City = "Monterrey",
                        State = "Nuevo Leon",
                        Country = "Mexico",
                        PostalCode = "64640"
                    }
                }
            };
            var customerReposityory = new CustomerRepository();

            //action
            var result = customerReposityory.Retrieve(1);

            //assert
            Assert.Equal(customer.CustomerId, result.CustomerId);
            Assert.Equal(customer.EmailAddress, result.EmailAddress);
            Assert.Equal(customer.FirstName, result.FirstName);
            Assert.Equal(customer.LastName, result.LastName);

            for (int i = 0; i < customer.AddressList.Count; i++)
            {
                Assert.Equal(customer.AddressList[i].AddresType, result.AddressList[i].AddresType);
                Assert.Equal(customer.AddressList[i].StreetLine1, result.AddressList[i].StreetLine1);
                Assert.Equal(customer.AddressList[i].City, result.AddressList[i].City);
                Assert.Equal(customer.AddressList[i].State, result.AddressList[i].State);
                Assert.Equal(customer.AddressList[i].Country, result.AddressList[i].Country);
                Assert.Equal(customer.AddressList[i].PostalCode, result.AddressList[i].PostalCode);
            }
        }
    }
}