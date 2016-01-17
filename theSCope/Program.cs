﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSCope
{
    class Scope
    {
        private static int x = 1;

        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("Local x in methods main is {0}", x);
            // UseLocalVariable has its own local x
            UseLocalVariable();

            // UseStaticVariable uses class Scope's static variable x
            UseStaticVariable();

            // UseLocalVariable reinitializes its own local x
            UseLocalVariable();

            // class Scope's static variable x retains its value
            UseStaticVariable();

            Console.WriteLine("\nlocal x in method Main is {0}", x);
        }

        public static void UseLocalVariable()
        {
            int x = 25; // initialized each time UseLocalVariable is called

            Console.WriteLine(
               "\nlocal x on entering method UseLocalVariable is {0}", x);
            ++x; // modifies this method's local variable x
            Console.WriteLine(
               "local x before exiting method UseLocalVariable is {0}", x);
        } // end method UseLocalVariable

        // modify class Scope's static variable x during each call
        public static void UseStaticVariable()
        {
            Console.WriteLine("\nstatic variable x on entering {0} is {1}",
               "method UseStaticVariable", x);
            x *= 10; // modifies class Scope's static variable x
            Console.WriteLine("static variable x before exiting {0} is {1}",
               "method UseStaticVariable", x);
        } // end method UseStaticVariable
    }
}
