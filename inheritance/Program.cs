using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Rectangle
    {
         // Member variable 
        protected double leght;
        protected double width;
        public Rectangle(double l, double w)
        {
            leght = l;
            width = w;
        }
        public double getArea()
        {
            return leght * width;
        }
        public void Display()
        {
            Console.WriteLine("Leght : {0}", leght);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area: {0}", getArea());
        }
    }
    class TableTop:Rectangle
    {
        private double cost;
        public TableTop(double l, double w)
            : base(l, w)
        { }

        public double getCost()
        {
        
            cost = getArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", getCost());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TableTop t = new TableTop(7.5, 2.3);
            t.Display();

        }
    }
}
