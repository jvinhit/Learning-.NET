using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToXML
{
    public class ExtensionDemo
    {
        public static void Demo()
        {
            string number = "42";
            
            // Could do it this way...
            //int x = Convert.ToInt32(number);

            // ...but do it this way for demo
            int x = number.ToInt();

            double d = 212.42;
            string dallors = d.DoubleToDollars();
            dallors = x.IntToDollars();
        }
    }

    /// <summary>
    /// Class to define extension methods for demo
    /// </summary>
    public static class Extensions
    {
        public static int ToInt(this string number)
        {
            return Int32.Parse(number);
        }

        public static string DoubleToDollars(this double number)
        {
            return string.Format("{0:c}", number);
        }

        public static string IntToDollars(this int number)
        {
            return string.Format("{0:c}", number);
        }
    }
}
