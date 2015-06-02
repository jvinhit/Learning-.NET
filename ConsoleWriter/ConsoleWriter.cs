using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriter
{
    public class ConsoleWriter
    {
        public static void Fuailture(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Write(message);   
        }
        public static void Success(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Write(mess);
        }
        public static void Write(string Message)
        {
            Console.WriteLine(Message);
            Console.ResetColor();
        }
    }
}
