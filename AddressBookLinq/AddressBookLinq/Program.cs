using System;
using System.Data;
namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to addressBook using Linq");
            AddressBook address = new AddressBook();
            address.CreateAddressTable();
            address.InsertinvaluesinRow();
            address.DisplayContacts();
            address.Edit();
            address.DeliteContact("Rishi");
            Console.WriteLine("after deliting Contact");
            address.DisplayContacts();
            address.GettingDataByCity();
        }
    }
}
