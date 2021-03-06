using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookLinq
{
   public class Contacts
    {
        /// <summary>
        /// properties of addressbook
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
        public long Phonenumber { get; set; }
    }
}
