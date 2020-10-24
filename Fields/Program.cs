using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.OrderList.Add(new Order());
            customer.OrderList.Add(new Order());

            customer.Promote();

            System.Console.WriteLine(customer.OrderList.Count);
        }
    }
}
