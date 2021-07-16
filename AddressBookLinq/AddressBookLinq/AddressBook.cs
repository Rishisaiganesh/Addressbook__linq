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
        /// <summary>
        /// inserting values in Row method
        /// </summary>

        public void InsertinvaluesinRow()
        {
           // table.Rows.Add("Rishi", "saiganesh", "Balaji nagr", "Nellore", "Ap", "509132", "8678906541", "ganesh74@gmail.com");
            table.Rows.Add("Reddy", "sravankumar", "X-nagar", "gadwal", "Delhi", "590345", "9085555321", "Booo87@gmail.com");
            table.Rows.Add("navin", "Reddy", "rrcomplex", "govindNagr", "Madhaypradesh", "509234", "7896555225", "abs888@gmail.com");
            table.Rows.Add("Bhasker", "sravankumar", "Ysrnagar", "Ananthpur", "Andhrapradesh", "590345", "9085555321", "Booo87@gmail.com");
            table.Rows.Add("rakesh", "Reddy", "Vijyacomplex", "Kadapa", "Andhrapradesh", "509234", "7896555225", "abs888@gmail.com");
            Console.WriteLine("Contact added succesfully");
        }
        /// <summary>
        /// Displaying method of contact list
        /// </summary>
        public void DisplayContacts()
        {
            foreach (var Table in table.AsEnumerable())
            {
                // getting all index in column.
                Console.WriteLine("\nFirstName:-" + Table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + Table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + Table.Field<string>("Address"));
                Console.WriteLine("City:-" + Table.Field<string>("City"));
                Console.WriteLine("State:-" + Table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + Table.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + Table.Field<long>("PhoneNumber"));
                Console.WriteLine("EmailId:-" + Table.Field<string>("EmailId"));
            }
        }
    }
}
