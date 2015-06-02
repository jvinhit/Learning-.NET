using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            IEnumerable<int> result =
                //from arrint in numbers
                //where arrint < 5
                //select arrint;
                // Using lambda expression ( using anonymous function ) 
                numbers.Where(delegate(int s)
                {
                    return s < 5;
                });

            // viet gon : 
            // numbers.Where(s=> s<5);
        

            foreach(int a in result)
            {
                Console.WriteLine("Hello linq : {0}", a);
            }
            char[] chars = new char[] { 'v', 'i', 'n', 'h' };
            IEnumerable<char> charletter =
                //from c in chars
                //where c == 'a' || c == 'v' || c == 'i'
                //select c;
                chars.Where(c => (c == 'a'|| c=='v'));
            foreach(char cs in charletter)
            {
                Console.WriteLine("Hello linq2 :{0}", cs);
            }

        }
    }
}
