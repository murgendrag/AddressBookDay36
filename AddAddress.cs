using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMultipleContact
{
    public class AddAddress
    {
        public List<AddressDetails> AddressDetailsList = new List<AddressDetails>();
        public void AddAddressToList(List<AddressDetails> addressDetails)
        {
            addressDetails.ForEach(addressData =>
            {
                Console.WriteLine("Address being added: " + addressData.FirstName + addressData.LastName);
                this.addEmployeePayRoll(addressData);
                Console.WriteLine("Address added : " + addressData.FirstName + addressData.LastName);
            });

        }

        private void addEmployeePayRoll(AddressDetails addres)
        {
            AddressDetailsList.Add(addres);
        }

        public void AddEmployeeToListWithThread(List<AddressDetails> addressDetails)
        {
            addressDetails.ForEach(addressData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Address being added: " + addressData.FirstName + addressData.LastName);
                    this.addEmployeePayRoll(addressData);
                    Console.WriteLine("Address added : " + addressData.FirstName + addressData.LastName);
                });
                thread.Start();
            });

            Console.WriteLine(this.AddressDetailsList);
        }
    }
}
