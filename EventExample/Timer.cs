using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    public delegate void TimerEventHandler(object sender, TimerchangedEvent args);

    public class TimerchangedEvent:EventArgs
    {
        private int tickleft;
        public int TickLeft
        {
            get
            {
                return this.tickleft;

            }
            set
            {
                this.tickleft = value;
            }
        }
        public TimerchangedEvent(int tickleft)
        {
            this.tickleft = tickleft;
        }
    }
    // Publisher : Lop phat sinh su kien 
    class Timer
    {
        public event TimerEventHandler TimerChanged;
        private int tickCount;

        public int TickCount
        {
            get { return tickCount; }
            set { tickCount = value; }
        }
        private int interval;

        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
        public Timer(int tickcount , int interval)
        {
            this.tickCount = tickcount;
            this.interval = interval;
        }
        public void OnTimerChanged(int ticlk )
        {
            if(TimerChanged != null)
            {
                TimerchangedEvent t = new TimerchangedEvent(ticlk);
                TimerChanged(this, t);
            }
        }
        public void Run()
        {
            int tick;
            tick = tickCount;
            while(tick >= 0)
            {
                
                System.Threading.Thread.Sleep(interval);
                tick--;
                OnTimerChanged(tick);
            }

        }
       public class Test
       {
           public static void TimerChangedEventss(object sender, TimerchangedEvent args)
           {
               Console.WriteLine(args.TickLeft);
           }
           public static void Main()
           {
               Timer t = new Timer(1000, 100);
               // Dang ky event
               t.TimerChanged += TimerChangedEventss;
               t.Run();
           }
       }
    }
}
