using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaexpressions
{
    class ex
    {
        static int[] numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        static string[] strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public static void sample1()
        {
            var fnums = numbers.Where(n => n > 5);
            Console.WriteLine("Number > 5 : ");
            foreach(int a in fnums)
            {
                Console.WriteLine("{0,4}", a);
            }
        }
        public static void Locrasochan()
        {
            IEnumerable<int> sochan = numbers.Where(num => num % 2 == 0);
            int n = numbers.First(b => b % 2 == 0);
            Console.WriteLine(n);
        }

        public static void sample2()
        {
            //string v = strings.First(s => s[0] == 'o');
            IEnumerable<string> v = strings.Where(s => s.StartsWith("s"));
            foreach(var sd in v)
            {
                Console.WriteLine(sd);
            }
        }

        public static void Main()
        {
            ex.sample1();
            ex.sample2();
            Locrasochan();
        }
    }
}
