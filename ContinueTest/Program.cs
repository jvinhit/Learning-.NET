using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueTest
{
    public class ContinueTest
    {
        public static void Main(string[] args)
        {
            for (int count = 1; count <= 10; count++) // loop 10 times
            {
                if (count == 5) // neu count nhay den 5
                    continue; // bo qua cac cau lenh ben duoi, va tiep tuc tang count len va tiep tuc thuc hien

                Console.Write("{0} ", count);
            }

            Console.WriteLine("\nUsed continue to skip displaying 5");
        }
    } 
}
