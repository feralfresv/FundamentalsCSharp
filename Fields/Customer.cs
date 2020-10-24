using System.Collections.Generic;

namespace Fields
{
    class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> OrderList = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            //OrderList = new List<Order>(); //error CS0191: A readonly field cannot be assigned to 
        }
    }
}
