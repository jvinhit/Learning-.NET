using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Extension method -> la mot phuong thuc mo rong, nam trong 1 class la static va method nayh cung phai la 1 method static 
 * trong phuong thuc nay keyword this dung de am chi data type se su dung no, va co the co nhieu hon 1 parameter , no cung co the 
 * tra ve gia tri. Vay tai sao cần extentsion method ? ???? 
 * 
 */
/*
 Nguyen Van Vinh Update 1
 */
namespace EXtensionMethod
{
    public delegate void SomeDelegate(int x);
    public delegate void InCuoi(string s);
    public delegate int ConvertString(string s);
    static class DateTimes
    {
        public static DateTime Combine(this DateTime dateC, DateTime timeC)
        {
            return new DateTime(dateC.Year, dateC.Month, dateC.Day, timeC.Hour, timeC.Minute, timeC.Millisecond);
        }
    }
    // extensoin method ~~ ? Static class and static method. Doi tuong su dung se la tham so dau tien co kieu trong <this>
    static class EX
    {
        public static void tangmang (this int [] mang, int sotang)
        {
            for(int i = 0 ; i < mang.Length; i++)
            {
                mang[i] += sotang;
            }
        }
        

        public static int CountWord (this string source)
        {
            return source.Split(new char[] {' ','.','?' },StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static string ResultString(this string sqrt, int count)
        {
            var result = new StringBuilder();
            for(int i = 0;  i< count ; i++)
            {
                result.Append(sqrt);
            }
            return result.ToString();
        }
    }
   
    class extensionMethod
    {
        
        static void tinhyeu(int x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> dsSO = num.Where(n => n % 2 == 0);
            foreach(var chansong in dsSO)
            {
                Console.WriteLine(chansong);
            }

            List<int> dsso = new List<int> { 1,2,3,4,5,6,7,8,9};

            List<int> chan = dsso.FindAll(x => x % 2 == 0);

            foreach (var so in chan)
            {
                Console.WriteLine(so);
            }
            Func<bool> boolsd = () => true;
           
            
            string vinh = "Vinh";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vinh.ResultString(10));
            var s = new SomeDelegate(tinhyeu);
            s(10);
            var s2 = new ConvertString(int.Parse);
            int xxx = s2("100");
            Console.WriteLine(xxx);
            InCuoi incuoi = delegate(string text)
            {
                Console.WriteLine("Vinh" + text);
            };
            incuoi("vinh");
            Func<string, int> predi = int.Parse;
            int nums = predi("10");
            Action<object> actiono = Console.WriteLine;
            actiono(1000);
            string testEX = "chan bo me ra. t?nh";
            Console.WriteLine(testEX.CountWord());
            int[] mangtest = new int[] { 1, 2, 3, 4 };
            mangtest.tangmang(10);
            for(int i = 0 ; i < mangtest.Length; i++)
            {
                Console.Write("\t\t{0}", mangtest[i]);
            }


            /// Su dung datetime
            /// 
            Console.WriteLine();

            DateTime date = DateTime.Parse("11/12/2012");
            DateTime time = DateTime.Parse("11/1/2015 9:55PM");
            // static member
            DateTime combined = DateTimes.Combine(date, time);
            // Extension method
            DateTime combine = date.Combine(time);
            Console.WriteLine("static : {0}", combined);
            Console.WriteLine("extension method: {0}", combine);


        }
    }
}
