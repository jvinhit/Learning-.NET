using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    /*
     Đối với từ khóa partical ta có thể khai báo 1 class hay 1 interface trong một hay nhiều tập tin khác nhau.
     * Mỗi tập tin sẽ chứa toàn bộ hay 1 phần của class, khi biên dịch chúng sẽ đc họp thành 1.
     * ======> ta có thể phân chia cấu trúc của class ra nhiều  phần, mỗi phần chia cho 1 nhóm lập trình đối với những project lớn 
     * class1.cs : class clsCommon chứa pt cong 2 so
     * class2.cs : class clsCommon chứa pt nhân 2 so
     * 
     */
    class Program
    {
        // trong ham main ta sẽ sử dụng clsCommon và 2 pt + *
        static void Main(string[] args)
        {
            clsCommon cls = new clsCommon();
            Console.WriteLine("+ : {0}", cls.sum());
            Console.WriteLine("* : {0}", cls.nhan());
        }
    }
}
