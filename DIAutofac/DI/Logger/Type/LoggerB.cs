using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DIAutofac.DI.Logger.Type
{
    class LoggerB:ILogger
    {
        public void WriteToLog(string mess)
        {
            var sw = new StreamWriter("LoggerBfile.txt");
            sw.Write(mess);
            sw.Close();
        }
    }
}
