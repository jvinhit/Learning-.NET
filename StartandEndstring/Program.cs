using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartandEndstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "started", "starting", "ended", "ending" };

            // test every string to see if it starts with "st"
            for (int i = 0; i < strings.Length; i++)
                if (strings[i].StartsWith("st"))
                    Console.WriteLine("\"" + strings[i] + "\"" +
                       " starts with \"st\"");

            Console.WriteLine();

            // test every string to see if it ends with "ed"
            for (int i = 0; i < strings.Length; i++)
                if (strings[i].EndsWith("ed"))
                    Console.WriteLine("\"" + strings[i] + "\"" +
                       " ends with \"ed\"");

            Console.WriteLine();
        }
    }
}
