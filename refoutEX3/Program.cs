using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refoutEX3
{
    // Khi sử dung từ khóa out sẽ không cần khởi tạo biến trước khi gọi hàm
    // Giá trị của tham số khi truyền vào lời gọi hàm có từ khóa out sẽ không đc giữ lại

    class Program
    {
    
        static void counter (out int i, int j)
        {
            // Bắt buộc phải khỏi tạo giá trị cho biến i
            i = 10;
            Console.WriteLine("i before plus is: {0}", i);
            Console.WriteLine("j before plus is {0}", j);
            i += 20;
            j += 10;
            Console.WriteLine("i after plus is: {0}", i);
            Console.WriteLine("j after plus is {0}", j);
            
        }
        static void Main(string[] args)
        {
            int n = 1000, m = 0;
            Console.WriteLine("n before : {0}", n);
            counter(out n, m);
            Console.WriteLine("n : {0} - m : {1}", n, m);

        }
    }
}
