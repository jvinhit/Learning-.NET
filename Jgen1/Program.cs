using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jgen1
{
    class Pair<T,U>
    {
        public T First { get; set; }
        public U Second{ get; set; }
        public override string ToString()
        {
            return "{ "+First+" , "+ Second+ " }";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pair<string, string> pairstring = new Pair<string, string>()
            {
                First = "Vinh",
                Second = "Thuy"
            };
            Console.WriteLine(pairstring.ToString());
        }
    }
}
