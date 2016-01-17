using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTest
{
    public class BreakTest
    {
        public static void Main(string[] args)
        {
            int count;

            for (count = 1; count <= 10; count++)
            {
                if (count == 5)
                    break;

                Console.Write("{0} ", count);
            }

            Console.WriteLine("\nBroke out of loop at count = {0}", count);
        } 
    } 
}
