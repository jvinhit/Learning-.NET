using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refoutEX1
{

    class Myclass
    {
        public int VAL = 20;
    }

    class Program
    {
        static void MyMethod(Myclass f1, int f2)
        {
            f1.VAL += 5;
            f2 += 5;
        }
        static void Main(string[] args)
        {
            Myclass a1 = new Myclass();
            int a2 = 10;
            MyMethod(a1, a2);
            Console.WriteLine("a1 = {0} and A2 = {1}", a1.VAL, a2);

        }
    }
}
