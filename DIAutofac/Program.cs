using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DIAutofac.DI.Logger;
using DIAutofac.DI.Logger.Type;
namespace DIAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance builder

            var builder = new ContainerBuilder();

            //char s = Convert.ToChar(Console.ReadLine());
            if (Properties.Settings.Default.LoggerAorB.ToUpper() == "B")
            {
                Console.WriteLine("LoggerA dc chon");
                builder.RegisterType<LoggerA>().As<ILogger>();//use Logger A 

            }
            else
            {
                Console.WriteLine("LoggerB  duoc chon");
                builder.RegisterType<LoggerB>().As<ILogger>();//use Logger B
            }
            // apply dependecy injection
            Program.Container = builder.Build();


            // Create SCope and Writelog Entry either via 
            using (var scope = Container.BeginLifetimeScope())
            {
                var logger = scope.Resolve<ILogger>();
                logger.WriteToLog(String.Format("{0} logger file to: ", DateTime.Now.TimeOfDay.ToString()));
            }
        }
        private static IContainer Container { get; set; }
    }
}
