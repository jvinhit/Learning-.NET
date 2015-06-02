using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncLamDele
{
    class Program
    {
        // Anonymous Method tuc la phuong thuc khong ten 
        // no duoc dinh nghia bang delegate

        public delegate void SomeThing(int [] z, int left, int right);
        public static void FineMax(int x)
        {
            int [] anh  = {1 , 2 ,3,4,5,6,7,8};
           
            SomeThing some = delegate(int [] sa, int left, int right)
            {
                left = 0;
                right = sa.Length - 1;
                int mid = (left + right) / 2;
                if (sa[mid] == x)
                    Console.WriteLine(mid);
                else if (sa[mid] > x)
                    right = mid - 1;
                else if (sa[mid] < x)
                    left = mid + 1;

            };
            some(anh, 0, anh.Length - 1);
           
        }
        static void Main(string[] args)
        {
            // public delegate bool Predicate<T> (T obj)
            //Func<bool> boolFunc =() => true;
            //Func<int, bool> intFunc = (x) => x < 10;
            //if (boolFunc() && intFunc(5))
            //    Console.WriteLine("5 < 10");

            Func<bool> boolFunc = delegate()
            {
                return true;
            };
            // Chuc nang cua Func<T , TResult> la de kiem tra 1 bieu thuc dau vao la dung 
            Func<string , bool> FuncString = delegate (string s)
            {
                return s.StartsWith("s"); 

            };

            Func<int, bool> intFunc = delegate(int x)
            {
                return x < 10;
            };
            if(intFunc(1) == boolFunc())
            {
                Console.WriteLine("10");
            }
            if(FuncString("song gio"))
            {
                Console.WriteLine(FuncString("song gio"));
            }

            // Chug nang cua Predicagte 
            int[] a = { 1, 3, 5, 6, 7, 87 };

            FineMax(4);
            //List<string> source = new List<string>() { "vinh","thuy","thao","truong","minh","dung","truyen"};
            //List<string> a = source.FindAll((s) => s.StartsWith("d"));
            //foreach(string b in a)
            //{
            //    Console.WriteLine(b);
            //}


        }
    }
}
