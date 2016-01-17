using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQuery
{
    public class Order
    {
        public int OrderID;
        public int CustomerID;
        public Customer Customer;
        public DateTime OrderDate;
        public decimal Total;

    }
}
