using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mang int co 10 ptu
            int[] mangints = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            int total = 0;
            foreach (var item in mangints)
            {
                Console.WriteLine(item);
                total = total + item;
            }
            Console.WriteLine("Tong mang  : " + total.ToString());
           // Su dung resize trong array :D 
            Console.WriteLine("Tong so phan tu : " + mangints.Length);

            Array.Resize(ref mangints, mangints.Length + 2);
            mangints[10] = 10;





        }
    }
}
