using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflectioncs
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 100;
            var text = "abc";

            Console.WriteLine(number.GetType().FullName);
            Console.WriteLine(text.GetType().FullName);

            Console.Read();
            //Phương thức GetType() chỉ có thể lấy được thông tin từ các biến đối tượng. Trong trường hợp muốn lấy thông tin của lớp thông qua tên lớp,
            //bạn phải sử dụng phương thức tĩnh Type.GetType(), tuy nhiên tham số truyền vào cần phải ghi đầy đủ cả namespace.

            // Không được ghi tham số là string, int hoặc Int32
            Type mType1 = Type.GetType("System.Int32");
            Type mType2 = Type.GetType("System.String");

            Console.WriteLine(mType1.FullName);
            Console.WriteLine(mType2.FullName);

            Console.Read();
           //Sử dụng toán tử typeof, bạn có thể lấy về đối tượng kiểu System.Type của bất kì kiểu nào với cú pháp typeof(type).

            Console.WriteLine(typeof(Int32).FullName);
            Console.WriteLine(typeof(String).FullName);

            Console.Read();
            // Thuc thi Reflection De get Member info cua mot doi tuong

            Type mType = typeof (MyClass);
            MemberInfo[] members = mType.GetMembers();
            Array.ForEach(members,mem=> Console.WriteLine(mem.MemberType.ToString().PadRight(12)+" : "+mem));
            Console.ReadLine();
            /*
             Ta sẽ trở lại với phần mở đầu của bài viết mà tôi nói về trường hợp thực thi một phương thức dựa vào tên mà người dùng truyền vào. 
             * Hãy xem các phương thức mà lớp Type cung cấp, có một phương thức tên là GetMethod(string methodName). 
             * Giá trị trả về của phương thức này là một đối tượng kiểu System.Reflection.MethodInfo chứa các thông tin về phương thức. 
             * Và đây là một ví dụ đơn giản minh họa cách dùng phương thức này:*/

            MyClass mc = new MyClass();
            Type mTy = mc.GetType();
            // get method SayHello
            MethodInfo myMethodInfo = mTy.GetMethod("SayHello");
           // invoke method:tham parameter second is null because method Sayhello not parameter
           // if method had a parameter thi tham so thu 2 se khac null
            myMethodInfo.Invoke(mc, null);
            Console.ReadLine();
        }
    }

    class MyClass
    {
        public string Name { get; set; }
        public static int theValue;

        public void SayHello()
        {
            Console.WriteLine("Say hello :"+ "Vinh");
        }
    }

}
