using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIIOC.Interface;

namespace DIIOC.Mock
{
    public class XMLDatabase:IDatabase
    {
        public void Save(int orderId)
        {
            Console.WriteLine("Data has been save to XML database ");
        }
    }
}
