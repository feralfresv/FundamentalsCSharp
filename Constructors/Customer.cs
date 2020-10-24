using System.Collections.Generic;
namespace Constructure
{
    public class Order
    { }
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> listorder;
        public Customer()
        {
            listorder = new List<Order>();
        }
        public Customer(int id) : this()
        {
            this.Id = id;
        } 
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}
