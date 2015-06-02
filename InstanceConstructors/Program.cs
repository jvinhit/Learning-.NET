using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceConstructors
{
    abstract class Shape
    {
        public const double pi = Math.PI;
        protected double x, y;
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract double Area();

    }
    class Cicle:Shape
    {
       public Cicle(double area):base(area,0)
        {

        }
       public override double Area()
       {
           return pi*x*x;
       }
    }
    class Cylinder:Cicle
    {
        public Cylinder(double radius, double height):base (radius)
        {

        }
        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * x * y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            double height = 3.0;

            Cicle ring = new Cicle(radius);
            Cylinder tube = new Cylinder(radius, height);

            Console.WriteLine("Area of the circle = {0:F2}", ring.Area());
            Console.WriteLine("Area of the cylinder = {0:F2}", tube.Area());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
