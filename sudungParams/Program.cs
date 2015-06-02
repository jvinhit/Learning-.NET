using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudungParams
{
    // params cho phép chỉ định tham số của phương thức là mảng tham số hay số lượng tham số quá lớn
    class UsingWithoutParams
    {
        public static void WithoutParams(int[] arr)
        {
            Console.WriteLine("-------------");
            foreach (var x in arr)
            {
                Console.Write(" {0} ", x);
            }
            Console.WriteLine();
            // cong them gia tri la 10
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
            // in ra
            Console.WriteLine("--- sau khi cong them 10---");
            foreach (var x in arr)
                Console.Write(" {0} ", x);
            Console.WriteLine();
        }
        public static void Run()
        {
            int[] n = new int[] { 1, 2, 3 };
            WithoutParams(n);
        }
    }


    // using Params
    class UsingParams
    {
        public static void usingParamsMethod(params int[] arr)
        {
            Console.WriteLine("-------------");
            foreach (var x in arr)
            {
                Console.Write(" {0} ", x);
            }
            Console.WriteLine();
            // cong them gia tri la 10
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
            // in ra
            Console.WriteLine("--- sau khi cong them 10---");
            foreach (var x in arr)
                Console.Write(" {0} ", x);
            Console.WriteLine();
        }
        public static void run()
        {
            // Khai bao va khoi tao ohuong thuc 3 bien 
            int i = 10, j = 20, k = 3;
            UsingParams.usingParamsMethod(i, j, k);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UsingWithoutParams.Run();
            UsingParams.run();
        }
    }
}
