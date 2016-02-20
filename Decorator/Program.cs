using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public interface IComputer
    {
        string description();
    }
    public class Computer : IComputer
    {
        public Computer()
        {
        }
        public string description()
        {
            return "computer";
        }
    }

    public class Disk : IComputer
    {
        IComputer computer;
        public Disk(IComputer c)
        {
            computer = c;
        }
        public string description()
        {
            return computer.description() + " and a disk";
        }
    }
    public class CD : IComputer
    {
        IComputer computer;
        public CD(IComputer c)
        {
            computer = c;
        }
        public string description()
        {
            return computer.description() + " and a CD";
        }
    }

    public class Monitor : IComputer
    {
        IComputer computer;
        public Monitor(IComputer c)
        {
            computer = c;
        }
        public string description()
        {
            return computer.description() + " and a monitor";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IComputer c = new Computer();
            Console.WriteLine("You're getting a " + new CD(new Monitor(new Disk(c))).description());
        }
    }
}
