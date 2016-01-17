using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* Tạo một lớp clock:
    - Khai báo 1 event OnSecondChanged trong Clock
    - 1 Method Run cứ 1s lại phát sinh sự kiện onSecondChanged
    - Tạo 2 lớp Analog va Digital Clock nhận sk của Clock*/
namespace EventClock
{



    public class Clock
    {
        public delegate void OnSecondChanged(object publisher, EventArgs args);
        public event OnSecondChanged SecondChangedHandler;
        // Khai bao delegate xu ly su kien say ra
        
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if(SecondChangedHandler!= null)
                {
                    SecondChangedHandler(this, new EventArgs());
                    Console.WriteLine("Phat sinh su kien");

                }
            }
        }

    }
    public class DigitalClock
    {
        // Ham dang ky xu ly su kien
        // Nhan tham so la doi tuong phat sinh su kien
        public void subcrible(Clock cl)
        {
            cl.SecondChangedHandler += new Clock.OnSecondChanged(Show);
        }
        // Phai them phuong thuc xu ly su kein vao trong delegate event handlercua lop phat sinh su ken
        public void Show(object obj,EventArgs a)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Digital Clocl: {0} {1} {2}", dt.Hour, dt.Minute, dt.Second);

        }
    }
    public class Analog
    {
        public void subcrible(Clock cl)
        {
            cl.SecondChangedHandler += new Clock.OnSecondChanged(Show);
        }
        // Phai them phuong thuc xu ly su kein vao trong delegate event handlercua lop phat sinh su ken
        public void Show(object obj, EventArgs a)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Digital Clocl: {0} {1} {2}", dt.Hour, dt.Minute, dt.Second);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DigitalClock digitalClock = new DigitalClock();
            Analog analoClock = new Analog();
            //analoClock.subscribe(clock);
            //digitalClock.subscribe(clock);
            //clock.SecondChangeHandler += new Clock.OnSecondChange(digitalClock.Show);
            clock.Run();
            Console.Read();
        }
    }
}
