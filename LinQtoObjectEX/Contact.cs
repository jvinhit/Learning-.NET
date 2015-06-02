using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoObjectEX
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }


        public static List<Contact> SampleData()
        {
            List<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact { FirstName = "Barney", LastName = "Gosttshall", DateOfBirth = new DateTime(1945, 10, 19), Phone = "885 983 8858", State = "CA" });
            contacts.Add(new Contact { FirstName = "Vinh", LastName = "Gosttshall", DateOfBirth = new DateTime(1991, 05, 24), Phone = "098 291 983", State = "CA" });
            contacts.Add(new Contact { FirstName = "Armando", LastName = "Valdes", DateOfBirth = new DateTime(1973, 12, 09), Phone = "848 553 8487", State = "WA" });
            contacts.Add(new Contact { FirstName = "Adam", LastName = "Gauwain", DateOfBirth = new DateTime(1945, 10, 19), Phone = "115 999 1154", State = "AK" });
            contacts.Add(new Contact { FirstName = "Jeffery", LastName = "Deane", DateOfBirth = new DateTime(1959, 10, 03), Phone = "677 602 6774", State = "CA" });
            contacts.Add(new Contact { FirstName = "Collin", LastName = "Zeeman", DateOfBirth = new DateTime(1950, 12, 16), Phone = "603 303 6030", State = "FL" });
            contacts.Add(new Contact { FirstName = "Stewart", LastName = "Kagel", DateOfBirth = new DateTime(1935, 02, 10), Phone = "546 607 5462", State = "WA" });
            contacts.Add(new Contact { FirstName = "Chance", LastName = "Lard", DateOfBirth = new DateTime(1951, 10, 21), Phone = "278 918 2789", State = "WA" });
            contacts.Add(new Contact { FirstName = "Blaine", LastName = "Reifsteck", DateOfBirth = new DateTime(1946, 05, 18), Phone = "715 920 7157", State = "TX" });
            contacts.Add(new Contact { FirstName = "Mack", LastName = "Kamph", DateOfBirth = new DateTime(1977, 09, 17), Phone = "364 202 3644", State = "TX" });
            contacts.Add(new Contact { FirstName = "Ariel", LastName = "Hazelgrove", DateOfBirth = new DateTime(1922, 05, 23), Phone = "165 737 1656", State = "OR" });
            return contacts;
        }
    }
}
