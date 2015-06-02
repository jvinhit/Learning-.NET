using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two instance dateTime
            DateTime dt = new DateTime();
            DateTime dt2 = new DateTime();
            // initalizing datetime object
            dt = DateTime.Now.Date;// initialize CurrentDate
            Console.WriteLine(dt);
            dt = dt.AddMinutes(5.0);
            Console.WriteLine(dt.ToString());
        }
    }
}
