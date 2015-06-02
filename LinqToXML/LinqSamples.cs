using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToXML
{
    public class LinqSamples
    {
        /// <summary>
        /// Demonstrate the var keyword
        /// </summary>
        public static void VarDemo()
        {
            var test = "Hello, World";
            var test2 = 42;

            // Can't compile this
            //test = test2;
        }

        /// <summary>
        /// Demonstrate lambda expressions
        /// </summary>
        public static void LambaExpressions()
        {
            string[] names = new string[] { "John", "Paul", "George", "Ringo" };
            var name = names.Select(s => s.StartsWith("P"));
            
            // This is somewhat analogous to the select method above
            //foreach(string s in names) { }

            int[] numbers = new int[] { 1, 20, 15, 35, 42, 18, 99 };
            var nums = numbers.OrderBy(x => x);
            //var nums = numbers.OrderBy(x => x).Reverse();
        }

        /// <summary>
        /// Demonstrate query expression and methods
        /// </summary>
        public static void CurrentCamp()
        {
            string[] camps = new string[] { "Code Camp 2007", "Code Camp 2008", "Code Camp 2009" };
            var currentCamp = from camp in camps
                              where camp.EndsWith(DateTime.Now.Year.ToString())
                              select camp;

            // These are all equivalent
            string currentCamp2 = camps.Where(c => c.EndsWith(DateTime.Now.Year.ToString())).Single();
            string currentCamp3 = camps.Single(c => c.EndsWith(DateTime.Now.Year.ToString()));
            string currentCamp4 = camps.Select(c => c).Where(c => c.EndsWith(DateTime.Now.Year.ToString())).Single();
        }

        /// <summary>
        /// Demonstrate lamda expressions and delegates
        /// </summary>
        public static void LambaExpressionsWithDelegates()
        {
            Func<string, bool> pOnly = delegate(string s) { return s.StartsWith("P"); };
            string[] names = new string[] { "John", "Paul", "George", "Ringo" };

            // Returns a sequence of values indicating
            // if the input element matched the expression
            var name1 = names.Select(pOnly);

            // These two statements are equivalent
            string name2 = names.Single(s => s.StartsWith("P"));
            string name3 = names.Single(pOnly);
        }
    }
}
