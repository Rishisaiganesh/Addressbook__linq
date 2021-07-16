using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinq
{
    public class AddressBook
    { 
        /// <summary>
        /// creating table and inserting values in colums
        /// </summary>
        DataTable table = new DataTable();
        public void CreateAddressTable()
        {
           
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Pincode", typeof(int));
            table.Columns.Add("Phonenumber", typeof(long));
        }
    }
}
