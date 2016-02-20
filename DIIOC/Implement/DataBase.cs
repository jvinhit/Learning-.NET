using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIIOC.Interface;

namespace DIIOC.Implement
{
    public class DataBase:IDatabase
    {
        public void Save(int orderId)
        {
            Console.WriteLine("Save to Database");
        }
    }
}
