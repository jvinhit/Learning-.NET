using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTASK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using task1
            Task.Factory.StartNew(() => { Console.WriteLine("A"); });

            //Using ACtion
            Task task = new Task(new Action(PrintMessage));
            task.Start();

            // using Delegate

            Task taks2 = new Task(delegate{
                    PrintMessage();
                });
            taks2.Start();
        }

        private static void PrintMessage()
        {
            Console.WriteLine("AD:");
        }



    }
}
