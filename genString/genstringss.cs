using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genString
{
    class genstringss
    {
        static void Main(string[] args)
        {
            /*How can I generate random 8 character alphanumeric strings in C#?*/
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            Console.WriteLine(result);
            // Func always use with extention method.
            Func<int, bool> predicates = delegate(int x)
            {
                return x % 2 == 0;
            };

            List<int> danhsach = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> sole = danhsach.Where(s => predicates(s));
             Console.Write("So le trong danh sach: ");
            foreach(int s in sole)
            {
                Console.Write(s+ " ");
            }
            Console.WriteLine();

            Console.WriteLine("Anonymous type : ");
            var sd = 10;
            Console.WriteLine(sd);
            var point = new { X = "ConCAC" };
            Console.WriteLine(point.X);
            string[] letters = new string[] { "a", "b", "c" };
            var lon = letters.Reverse(); // [source].Reverse();
            foreach(var s in lon)
            {
                Console.WriteLine("Lon" + s);
            }


        }
    }
}
