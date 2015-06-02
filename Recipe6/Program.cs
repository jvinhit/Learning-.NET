using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace Recipe6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current thread priority: {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Chay trong tat ca cac core co san");
            RunThread();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Chay trong 1 core");
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
            RunThread();

            ProcessThreadCollection currentThreads = Process.GetCurrentProcess().Threads;

            foreach (ProcessThread thread in currentThreads)
            {
                Console.WriteLine(thread.Id.ToString());
            }
        }
        static void RunThread()
        {
            var sample = new ThreadSample();
            var threadOne = new Thread(sample.CounterNumber);
            threadOne.Name = "Thread One ";
            var threadTwo = new Thread(sample.CounterNumber);
            threadTwo.Name = "Thread Two";
            threadOne.Priority = ThreadPriority.Highest;
            threadTwo.Priority = ThreadPriority.Lowest;
            threadTwo.Start();
            threadOne.Start();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            sample.Stop();

        }
        class ThreadSample
        {
            private bool _isStopped = false;
            public void Stop()
            {
                _isStopped = true;
            }
            public void CounterNumber()
            {
                long counter = 0;
                while (!_isStopped)
                {
                    counter++;

                }
                Console.WriteLine("{0} Delay with {1,11} priority " + "has a count= {2,13} ", Thread.CurrentThread.Name, Thread.CurrentThread.Priority, counter.ToString("NO"));
            }
        }
    }

    

}
