using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int custoemrId)
        {
            var customer = new Customer(custoemrId);

            if (custoemrId == 1)
            {
                customer.EmailAddress = "fer@gmail.com";
                customer.FirstName = "Fernando";
                customer.LastName = "Sanchez";
                customer.AddressList = addressRepository.RetrieveByCustoemrId(custoemrId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}