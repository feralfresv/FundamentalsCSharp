using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddresType = 1;
                address.StreetLine1 = "St1";
                address.StreetLine2 = "St2";
                address.City = "Merida";
                address.State = "Yucatan";
                address.Country = "Mexico";
                address.PostalCode = "97133";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustoemrId(int customerId)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddresType = 1,
                StreetLine1 = "St1",
                StreetLine2 = "St2",
                City = "Merida",
                State = "Yucatan",
                Country = "Mexico",
                PostalCode = "97133"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddresType = 2,
                City = "Monterrey",
                State = "Nuevo Leon",
                Country = "Mexico",
                PostalCode = "64640"
            };
            addressList.Add(address);        

            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}