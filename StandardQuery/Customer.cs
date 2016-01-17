using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQuery
{
    public class Customer
    {
        public int CustomerID;
        public string Name;
        public string Address;
        public string City;
        public string Region;
        public string PostalCode;
        public string Country;
        public string Phone;
        public List<Order> Orders;

        static List<Customer> GetCustomerList()
        {
            List<Customer> listCustomer = new List<Customer>()
            {
                new Customer(){CustomerID = 1,
                    Name = "Vinh",Address = "Ho Chi Minh",City = "Tay Ninh",Region = "Viet Nam",PostalCode = "70000",Country = "Viet Nam",Phone = "0982999999" ,Orders = new List<Order>(){new Order(){OrderID = 1,CustomerID = 1,}}}
            };
            return listCustomer;
        }

    }

}
