using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastDelegate
{
    public delegate void StringDelegates(string value);
    public class MulticastEXample
    {
        public void PrintString(string value)
        {
            Console.WriteLine(value);
        }
        public void PrintStringLenght(string value)
        {
            Console.WriteLine(value.Length);
        }
        public void PrintStringWithDate(string value)
        {
            Console.WriteLine("{0}: {1}", DateTime.Now, value);
        }
        public static void PrintInvocationList(Delegate someDelegate)
        {
            Console.Write("(\t");
            Delegate[] list = someDelegate.GetInvocationList();
            foreach(Delegate d  in list)
            {
                Console.Write("{0} + ", d.Method.Name);
            }
            Console.Write("\t)");
            Console.WriteLine();
        
        }
        static void Main(string[] args)
        {
            MulticastEXample mdelex = new MulticastEXample();
            StringDelegates printDelegate = new StringDelegates(mdelex.PrintStringLenght);

            PrintInvocationList(printDelegate);

            ///
            printDelegate = (StringDelegates)Delegate.Combine(printDelegate, printDelegate);
            PrintInvocationList(printDelegate);
            printDelegate += new StringDelegates(mdelex.PrintString);
            PrintInvocationList(printDelegate);
            printDelegate -= mdelex.PrintStringLenght;
            PrintInvocationList(printDelegate);
        }
    }
}
