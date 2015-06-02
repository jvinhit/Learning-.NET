using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recusive
{
    class Program
    {
        static readonly string[] elements = { "hi", "a", "b" };
        static int[] variations;
        static int N;
        const int K = 2;
        static void Variations(int index)
        {
            if(index >= K)
            {

            }
        }
        public static int Giaithua(int n)
        {
            if(n==0)
                return 1;
            else
                return n*Giaithua(n-1);

        }
        public static void TinhGT()
        {
            
            char ch;
            do
            {
                Console.WriteLine("Moi ban nhap");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Gia thua cua {0} = {1}", n, Giaithua(n));
                Console.WriteLine("Ban co muon tiep tuc khong? C/K?");
                ch = (char)Console.Read();

            } while (ch == 'c' || ch == 'C');

        }
        public static int Fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
                return 1;
            else
                return Fibo(n - 1) + Fibo(n -2);
        }
        public static long Sum(int n)
        {
            if (n == 1)
                return 1;
            else
                return (Sum(n - 1) + n);
        }
        static void Main(string[] args)
        {
            // Count run time : 
            var stopWatch = Stopwatch.StartNew();
            int n = int.Parse(Console.ReadLine());
            long k = Fibo(n);
            stopWatch.Stop();
            
            Console.WriteLine(k);

            var thoigiancahy = stopWatch.Elapsed.Seconds.ToString() ;
            Console.WriteLine(thoigiancahy);
            Console.WriteLine("Tong: {0}", Sum(10000));
            TinhGT();
        }

    }
}
