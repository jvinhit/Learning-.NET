using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace refoutEX2
{
    // ref truyền giá trị theo tham biến, khi đi ra khỏi hàm thì giá trị sẽ thay đổi và đc  giữ giá trị thay đổi
    // Khi tham số có khai báo từ khóa ref thì giá trị mà tham số này đang nắm giữ khi truyền vao phương thức sẽ đc giữ lại.
    // Đây là sự khác biệt cơ bản giữa ref và out
    class Program
    {
        public static void restrictInit(ref Hashtable hash)
        {
            hash.Add("1", "C# 3");
            hash.Add("2", "C# 3");
            hash.Add("3", "C# 3");
            hash.Add("4", "C# 3");

        }
        static void Main(string[] args)
        {
            Hashtable h = null;
            h.Add("0", "Do nothing");
            restrictInit(ref h);
            foreach(var s in h.Keys)
            {
                Console.Write("Key = {0}", s);
                Console.WriteLine("Value ={0} ", h[s]);
            }
        }
    }
}
