using System;

namespace Constructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Fer");
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            //Another way early but onyl if is necesarry. With this help us to 
            //elimintate de overwritre in the class
            var customer2 = new Customer
            {
                Id = 2,
                Name = "Alfredo"
            };

            System.Console.WriteLine(customer2.Id);
            System.Console.WriteLine(customer2.Name);
        }

    }
}
