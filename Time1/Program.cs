using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time1
{
    public class Time1
    {
        private int hour;
        private int minutes;
        private int seconds;

        public void SetTime(int h, int m, int s)
        {
            hour = ((h >= 0 && h <= 24) ? h : 0);
            minutes = ((m >= 0 && m <= 60) ? m : 0);
            seconds = ((s >= 0 && s <= 60) ? s : 0);

        }

        public string ToUniversalString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minutes, seconds);

        }

        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3}", (hour == 0 || hour == 12) ? 12 : hour % 12, minutes, seconds, (hour < 12 ? "AM" : "PM"));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create and initialize a Time1 object
            Time1 time = new Time1(); // invokes Time1 constructor

            // output string representations of the time
            Console.Write("The initial universal time is: ");
            Console.WriteLine(time.ToUniversalString());
            Console.Write("The initial standard time is: ");
            Console.WriteLine(time.ToString());
            Console.WriteLine(); // output a blank line

            // change time and output updated time 
            time.SetTime(13, 27, 6);
            Console.Write("Universal time after SetTime is: ");
            Console.WriteLine(time.ToUniversalString());
            Console.Write("Standard time after SetTime is: ");
            Console.WriteLine(time.ToString());
            Console.WriteLine(); // output a blank line

            // set time with invalid values; output updated time 
            time.SetTime(99, 99, 99);
            Console.WriteLine("After attempting invalid settings:");
            Console.Write("Universal time: ");
            Console.WriteLine(time.ToUniversalString());
            Console.Write("Standard time: ");
            Console.WriteLine(time.ToString());
        }
    }
}
