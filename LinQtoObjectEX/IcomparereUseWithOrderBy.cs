using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoObjectEX
{
    // OrderBy used with ICompapre
    public  class RandomShuffleStringSort<T>:IComparer<T>
    {
        internal Random random = new Random();
        public int Compare(T x, T y)
        {
            //get a random number : 0 or 1
            int i = random.Next(2);
            if (i == 0)
                return -1;
            else
                return 1;
        }

        public void ex14()
        {
            string[] strings = new string[] { "1- one", "2- two", "3- three", "4- four", "5- five" };
            var normal = strings.OrderBy(s=> s.Length);
            var custom = strings.OrderBy(s => s, new RandomShuffleStringSort<string>());
            Console.WriteLine("Normal sort order: ");
            foreach(var s in normal)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Custom sort order: ");
            foreach(var s2 in custom)
            {
                Console.WriteLine(s2);
            }
        }
    }
}
