using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenConstraint
{
    public class One { public One() { } }
    public class Two:One 
    {
        public Two() { }
        public Two(int c, char h) { } 
    }

    class genwithConstraint
    {
        // RAng buoc tham so voi constructor 
        static T Proceduce<T>() where T : One, new()
        {
            T returnVal = new T();
            return returnVal;
        }
        static void Main(string[] args)
        {
            Proceduce<One>();
            Proceduce<Two>();

        }
    }
}
