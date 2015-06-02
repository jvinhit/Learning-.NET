using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoObjectEX
{
    class Order
    {
        public string CustomerID { get; set; }
        public string OrderNumber { get; set; }
        public static List<Order> SampleDataOrder()
        {
            List<Order> listOrder = new List<Order>() { 
                new Order{CustomerID ="GOT1",OrderNumber="Order 1"},
                new Order{CustomerID ="GOT1",OrderNumber="Order 2"},
                new Order{CustomerID ="DEA1",OrderNumber="Order 3"},
                new Order{CustomerID ="DEA1",OrderNumber="Order 4"},
                new Order{CustomerID ="ZEE1",OrderNumber="Order 5"}
            };
            return listOrder;
        }
    }
}
