using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DIAutofac.DI.Logger.Type
{
    class LoggerA:ILogger
    {
        public void WriteToLog(string mess)
        {
            var sw = new StreamWriter("LoggerAfile.txt");
            sw.Write(mess);
            sw.Close();
        }
    }
}
