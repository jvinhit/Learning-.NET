using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace LinqEX1
{

    // Example lambda! jvinhit@gmail.com
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "vinh", "thuy", "thao", "duyen", "xuan truong" };
            IEnumerable<string> s1 = from a in s
                                     where a.Length <= 5
                                     orderby a
                                     select a;
            /*<=> 
             from chan in a 
             select chan*/

            var s2 = s.Select(g => g).Where(g => g.Length < 5).OrderBy(g => g);
            var s3 = s.Select(g => g).Where(g => g.Contains("vinh")).OrderBy(g => g);
            /*
              * from chan in a 
             *  where a.lehgnt   < 6
             */
            /* < => 
             * a.Select(s => s).Where(
             *
             *
             */
            foreach (string layra in s1)
            {
                Console.Write("{0,10}", layra);
            }
            foreach (string chan in s2)
            {
                Console.WriteLine("\n{0,10}", chan);
            }

            Console.ReadLine();
            string[] presidents = { "Adams", "Arthur", "Buchanan",
  "Bush", "Carter","Cleveland","Clinton", "Coolidge",
  "Eisenhower", "Fillmore", "Ford", "Garfield","Grant",
  "Harding", "Harrison", "Hayes", "Hoover", "Jackson",
  "Jefferson", "Johnson", "Kennedy", "Lincoln",
  "Madison", "McKinley", "Monroe", "Nixon", "Pierce",
  "Polk", "Reagan", "Roosevelt", "Taft", "Taylor",
  "Truman", "Tyler", "Van Buren", "Washington",
  "Wilson"};
            string president =
                (from aks in presidents
                 where aks.StartsWith("Lin")
                 select aks).First();
            //presidents.Where(p => p.StartsWith("Lin")).First();
            Console.WriteLine(president);
            Console.WriteLine(s2.Count());
            foreach (string chan in s3)
            {
                Console.WriteLine("\n{0,10}", chan);
            }

            Console.ReadLine();

            int number = 11;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number - i; j++)
                    Console.Write("-");
                for (int k = 1; k <= i; k++)
                    Console.Write(" *");
                Console.WriteLine("");
            }
            Console.ReadLine();
            Console.WriteLine("Program for displaying pattern of *.");
            Console.Write("Enter the maximum number of *: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHere is the Diamond of Stars\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                for (int k = 1; k < i; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
