using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Recipe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh bat dau.....");
            Thread t = new Thread(PrintNumberWithStatus);
            Thread t2 = new Thread(DoNoThing);

            Console.WriteLine("trang thai ban dau cua thread t : Unstarted === "+t.ThreadState.ToString());
            t2.Start(); // Do No thing thuc hien xong xong voi Main t2 is Started
            t.Start(); // t started Status
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("-----" + i);
                Console.WriteLine("- t after start(): " + t.ThreadState.ToString());
                Console.WriteLine("**T2 AFFTER START : " + t2.ThreadState.ToString());
            }
            Console.WriteLine(Thread.CurrentThread.ThreadState.ToString());
            t.Abort();
            Console.WriteLine("SAU KHI THREAD T GOI ABORT: ");
            Console.WriteLine("t threa is : "+t.ThreadState.ToString());
            Console.WriteLine("t2 Thread is :" +t2.ThreadState.ToString());

        }
        static void DoNoThing()
        {

          Thread.Sleep(TimeSpan.FromSeconds(3));  
        }
        static void PrintNumberWithStatus()
        {
            Console.WriteLine("Starting Mthod Status");
            Console.WriteLine(Thread.CurrentThread.ThreadState.ToString());
            for (int i = 0; i < 10; i++)
            {
                //Thread.Sleep(TimeSpan.FromSeconds(10));
                Console.WriteLine("Thread status: "+i);
            }
        }
    }
}
