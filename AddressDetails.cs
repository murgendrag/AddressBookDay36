using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMultipleContact
{
    public class AddressDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string EmailID { get; set; }

        public int Zip { get; set; }

        public AddressDetails(string FirstName, string LastName, string Address, string City,
            long PhoneNumber, string State, string EmailID, int Zip)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.State = State;
            this.City = City;
            this.EmailID = EmailID;
            this.Zip = Zip;

        }

    }
}
