using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIIOC.Interface;

namespace DIIOC.Implement
{
    public class Logger:ILogger
    {
        public void LogInfo(string info)
        {
            Console.WriteLine("Save to Log");
        }
    }
}
