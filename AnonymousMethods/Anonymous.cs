using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Example Func<T1,T2,TResult> -> return value of type TResult
// Func is delegate 
namespace AnonymousMethods
{
    class Customer
    {
        public String Name { get; set; }
    }

    class Person
    {
        public Int32 Age { get; set; }
        public String City { get; set; }
    }
    class Anonymous
    {
        public static void Excuter<T>(Action<T> action, T parameter)
        {
            action(parameter);
        }
        public static void HanhDongKhac(int so)
        {
            Console.WriteLine(so + 10);
        }
        public static void HanhDongInTring(string s)
        {
            Console.WriteLine("Hanh dong khac  " + s);
        }
        public static void HanhDong3TS(int x, string s, double b)
        {
            Console.WriteLine(x + " " + s + " " + b);
        }
        public static void AppendText(string s1, string s2)
        {
            Console.WriteLine(s1
                + s2);
        }
        static void Main(string[] args)
        {

            Action<string> action = Console.WriteLine;
            action("Nguyen Hoang Mai THao");

            Action<int> inso = Console.WriteLine;
            int number = 4;
            Excuter(Console.WriteLine, number);
            Excuter(HanhDongKhac, number);
            Excuter(HanhDongInTring, "Nguyen Van Vinh");
            Action<int, string, double> ActionSomepara;



            ActionSomepara = HanhDong3TS;
            ActionSomepara(100, "Vinh", 10.01);


            ///Sample lambda expression declared  as delegate
            ///
            
            Func<int, int> lambda1 = x => x + 1;                    // Implicitly typed, expression body
            Func<int, int> lambda2 = x => { return x + 1; };        // Implicitly typed, statement body
            Func<int, int> lambda3 = (int x) => x + 1;              // Explicitly typed, expression body
            Func<int, int> lambda4 = (int x) => { return x + 1; };  // Explicitly typed, statement body
            Func<int, int, int> lambda5 = (x, y) => x * y;          // Multiple parameters
            Func<int> lambda6 = () => 1;               
            // No parameters, expression body
            Action lambda7 = () => Console.WriteLine();             // No parameters, statement body
            Func<Customer, String> lambda8 = customer => customer.Name;
            Func<Person, Boolean> lambda9 = person => person.City == "Paris";
               
            Func<Person, Int32, Boolean> lambda10 = (person, minAge) => person.Age >= minAge;
            // lambda expression without parameter
            Func<DateTime> getDateTime = () => DateTime.Now;

            ConsoleWriter.ConsoleWriter.Success(lambda9.ToString());

            // lambda expression with an implicitly-typed string parameter
            Action<string> printImplicit = s => Console.WriteLine(s);

            // lambda expression with an explicitly-typed string parameter
            Action<string> printExplicit = (string s) => Console.WriteLine(s);

            // lambda expression with two implicitly-typed parameters
            Func<int, int, int> sumInts = (x, y) => x + y;

            // Predicate<T> and Func<T, Boolean> are equivalent (but not compatible)
            Predicate<int> equalsOne1 = x => x == 1;

            Predicate<int> equalsOneEXtension =
                (int x) =>
                {
                    return x > 10;
                };
            Func<int, bool> equalsOne2 = x => x == 1;

            // these lambda expressions have expression bodies
            Func<int, int> incInt = x => x + 1;
            Func<int, double> incIntAsDouble = x => x + 1;

            // lambda expression with a statement body and explicitly-typed parameters
            Func<int, int, int> comparer = (int x, int y) =>
            {
                if (x > y) return 1;
                if (x < y) return -1;
                return 0;
            };




            Func<int, int, bool> kiemtra = (x, y) =>
                {
                    if (x > y)
                        return true;
                    return false;
                };

            Console.WriteLine("A"+kiemtra(10, 5).ToString());



            // using Anonymous Type 
            var point = new { X = 3, Y = 3, Z = 3 };
            Console.Write("Point with x = {0} and Y = {1} and Z = {2}", point.X, point.Y, point.Z);

            Func<string, int, int> lambda = (x, y) => int.Parse(x) + y;
            ConsoleWriter.ConsoleWriter.Success(lambda("10", 2).ToString());
        
        }


        public class Jvinhit
        {
            public static bool IsPositive(int num)
            {
                return num > 0;
            }
            public static void usingGunc()
            {
                Func<int, bool> thu = delegate(int num)
                {
                    return num > 0;
                };
            }
            public static void Test(int num)
            {
                Func<int, bool> funcBos = new Func<int, bool>(IsPositive);
               
                Console.WriteLine(funcBos(10));                 
            }
        }
    }
}
