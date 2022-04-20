using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMultipleContact
{
    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("Welcome ");

            List<AddressDetails> addressDetails = new List<AddressDetails>();
            addressDetails.Add(new AddressDetails(FirstName: "Suresh", LastName: "Patil", Address: "xy Apartment",
                City: "Mumbai", State: "Maharashtra", Zip: 400708,
                EmailID: "shdjfgs@gmail.com", PhoneNumber: 8694734856
             ));
            addressDetails.Add(new AddressDetails(FirstName: "Peter", LastName: "Roderige", Address: "er Apartment",
                City: "Bengalore", State: "Karnataka", Zip: 400458,
                EmailID: "ggufgs@gmail.com", PhoneNumber: 824578458
            ));

            addressDetails.Add(new AddressDetails(FirstName: "Ramesh", LastName: "Patel", Address: "xy Apartment",
                City: "Mumbai", State: "Maharashtra", Zip: 400708, EmailID: "shdjfgs@gmail.com", PhoneNumber: 8694734856));

            addressDetails.Add(new AddressDetails(FirstName: "Farhan", LastName: "Quershi", Address: "y Apartment",
                City: "Delhi", State: "Delhi", Zip: 500708, EmailID: "shdjfgs@gmail.com", PhoneNumber: 8694734856));

            addressDetails.Add(new AddressDetails(FirstName: "Geeta", LastName: "yadav", Address: "x Apartment",
                City: "Noida", State: "Delhi", Zip: 400708, EmailID: "shdjfgs@gmail.com", PhoneNumber: 8694734856));

            addressDetails.Add(new AddressDetails(FirstName: "Sam", LastName: "kiran", Address: "xy Apartment",
                City: "Mumbai", State: "Maharashtra", Zip: 400708, EmailID: "shdjfgs@gmail.com", PhoneNumber: 8694734856));

            AddAddress address = new AddAddress();
            address.AddAddressToList(addressDetails);

            Console.WriteLine("----------------");
            Console.WriteLine("Use of MultiThreading");
            //thread used to add address
            AddAddress address1 = new AddAddress();
            address1.AddEmployeeToListWithThread(addressDetails);
        }
    }
}
