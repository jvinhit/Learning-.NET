using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoObjectEX
{
    public class Customers
    {
        public string CustomerID { get; set; }
        public string LastName { get; set; }

        public static List<Customers> SampledataCustomer()
        {
            List<Customers> listCustomers = new List<Customers>()
            {
                new Customers{CustomerID="GOT1",LastName="Gottshall"},
                new Customers{CustomerID="VAL1",LastName="Valdes"},
                new Customers{CustomerID="GAU1",LastName="Gauwain"},
                new Customers{CustomerID="DEA1",LastName="Deane"},
                new Customers{CustomerID="ZEE1",LastName="Zeeman"},

            };
            return listCustomers;
        }
    }
}
