using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuocTinhStatic
{
    class Class1
    {
        // local variable
        private static string sName;
        private static string sAddress;
        private static int age;
        public static int Age
        {
            get { return age; }
            set
            {
                if (value > 100)
                    age = 100;
                else
                    age = value;
            }
        }
        public static string SName
        {
            get
            { return sName; }
            set
            {
                sName = value;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1.SName = "Vinh";
            Class1.Age = 200;
            Console.WriteLine(Class1.SName + "---" + Class1.Age);
        }
    }
}
