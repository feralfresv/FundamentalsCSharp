using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        private const string V = "";

        [Fact]
        public void FullNameTestValid()
        {
            var customer = new Customer();
            customer.FirstName = "Fernando";
            customer.LastName = "Sanchez";


            var expected = "Sanchez, Fernando";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirtsNameEmpty()
        {
            var customer = new Customer();          
            customer.LastName = "Sanchez";

            var expected = "Sanchez";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastsNameEmpty()
        {
            var customer = new Customer();
            customer.FirstName = "Fernando";
            
            var expected = "Fernando";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            var c1  = new Customer();
            c1.FirstName= "Fer1";
            Customer.InstanceCountty+=1;
            
            var c2  = new Customer();
            c2.FirstName= "Fer2";
            Customer.InstanceCountty+=1;
            
            var c3  = new Customer();
            c3.FirstName= "Fer3";
            Customer.InstanceCountty+=1;


            Assert.Equal(3, Customer.InstanceCountty);
        }

        [Fact]
        public void ValidateValid()
        {
            //arrange
            var customer = new Customer
            {
                LastName= "Sanchez",
                EmailAddress= "fer@gmail.com"
            };
            var expected = true;

            //-Action
            var result = customer.Validate();

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //arrange
            var customer = new Customer
            {
                EmailAddress = "fer@gmail.com"
            };
            var expected = false;

            //action
            var resut = customer.Validate();

            //assert
            Assert.Equal(expected, resut);

        }
    }
}
