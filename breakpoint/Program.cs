using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new string[] { "vinh", "Thuy", "Thao", "Truyen", "Truong", "Nam" };
            Dowork(fruits);
            Console.ReadLine();

            
        }
        private static void Dowork(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
