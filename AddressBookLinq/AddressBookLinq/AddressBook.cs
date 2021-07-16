using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            table.Rows.Add("Rishi", "saiganesh", "Balaji nagr", "Nellore", "Ap", "509132", "8678906541");
            table.Rows.Add("Reddy", "sravankumar", "X-nagar", "gadwal", "Delhi", "590345", "9085555321" );
            table.Rows.Add("navin", "Reddy", "rrcomplex", "govindNagr", "Madhaypradesh", "509234", "7896555225" );
            table.Rows.Add("Bhasker", "sravankumar", "Ysrnagar", "Ananthpur", "Andhrapradesh", "590345", "9085555321");
            table.Rows.Add("rakesh", "Reddy", "Vijyacomplex", "Kadapa", "Andhrapradesh", "509234", "7896555225");
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
                Console.WriteLine("FirstName:-" + Table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + Table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + Table.Field<string>("Address"));
                Console.WriteLine("City:-" + Table.Field<string>("City"));
                Console.WriteLine("State:-" + Table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + Table.Field<int>("PinCode"));
                Console.WriteLine("PhoneNumber:-" + Table.Field<long>("PhoneNumber"));
            }
        }
        public void Edit()
        {
            try
            {
                string newName = "Ganesh";
                var EditContact = table.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(newName)).FirstOrDefault();
                if (EditContact != null)
                {
                    EditContact.SetField("LastName", "Sai");
                    EditContact.SetField("PhoneNumber", "9898989898");
                    EditContact.SetField("City", "VijayaWada");
                    EditContact.SetField("State", "Andhrapradesh");
                    Console.WriteLine("New Contact Edit", newName);
                    DisplayContacts();
                }
                else
                {
                    Console.WriteLine("there is no Such Contact address");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DeliteContact(string firstName)
        {
            try
            {
                var DelitingRow = table.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals(firstName)).FirstOrDefault();
                if(DelitingRow != null)
                {
                    DelitingRow.Delete();
                    Console.Write("Contacts delite sucessfully", firstName);
                    DisplayContacts();
                }
                else
                {
                    Console.WriteLine("There is no such Type FirstName in Contact list");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        public void GettingDataByCity()
        {
            Contacts contacts = new Contacts();
            var records = table.AsEnumerable().Where(x => x.Field<string>("City").Equals(contacts.City)).FirstOrDefault();
            foreach (var table in table.AsEnumerable())
            {
                // Get all field by column index.
                Console.WriteLine("FirstName:-" + table.Field<string>("FirstName") + "LastName:-" + table.Field<string>("LastName") + "Address:-" + table.Field<string>("Address") +
                    " City:-" + table.Field<string>("City") + " State:-" + table.Field<string>("State") +
                    "PinCode:-" + table.Field<string>("PinCode") + " PhoneNumber:-" + table.Field<string>("PhoneNumber"));
            }
        }
    }
}
