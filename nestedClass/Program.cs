using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedClass
{
    /*-
     * Sử dụng Nested class => Class nong nhau cho phep su dung chung trong noi bo class chua no khi tam vuc la public*/
    class Class1
    {
        int i = 10;
        int j = 20;
        public int sum()
        {
            return i + j;

        }
        public class Class2
        {
            int a = 1;
            int b = 2;
            public int sum()
            {
                return a + b;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Mot khi da khai bao class lồng trong 1 class thì khi kb va sd phải chỉ định class chứa nó
            Class1.Class2 cls = new Class1.Class2();
            Console.WriteLine(cls.sum());
        }
    }
}
