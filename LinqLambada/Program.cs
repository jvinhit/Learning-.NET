using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambada
{
    static class Sample
    {
        private static int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private static string[] strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        class Person
        {
            public string Name { get; set; }
            public int Level { get; set; }


        }
        private static Person[] persons = new Person[]
            {
                new Person(){Name = "Vinh",Level = 20},
                new Person(){Name = "Linh",Level = 21}, 
                new Person(){Name = "Trang",Level = 22}, 
                new Person(){Name = "Thao",Level = 23}, 
                new Person(){Name = "Thuy",Level = 24}, 
 
            };


        public static void sample1()
        {
            // First( this Source > return Tsource 
            // First( this Source , Func<Tsource, bool> predicate> 
            // -> Last la lay phan tu cuoi cung 
            // Last cung co 2 dang khong tham so va co tham so 
            // Tham so o day la dieu kien loc
            // Fisrt Hoac Last se tra ve 1 gia tri, neu ko co gia tri phu hop se bao loi null exception 
            // -> khi do ta su dung firstordefault

            string v = strings.First();

            string t = strings.FirstOrDefault(x => x.Length > 13);
            Console.WriteLine("First not parameter :" + v + " First have a predicate : " + t);
        }

        public static void sample2()
        {
            // using where filter trong source => tra ve mot day cac phan tu 
            IEnumerable<int> filter = numbers.Where(x => x > 5);
            foreach (var variable in filter)
            {
                Console.Write(variable + " ");
            }
        }

        public static void sample3()
        {
            // select use to convert each element to new value
            var selectStatement = numbers.Select(n => strings[n]);
            //Console.WriteLine(selectStatement.GetType().Assembly.ToString());
            Console.WriteLine(selectStatement);
            // Using select get IEnumerator from soure
            // Get all elements in source
            var selects = numbers.Select(n => n);
            // using select get elements and filter
            var selectss = numbers.Select(n => n % 2 == 0);
            // using Select with Where
            var selectsss = numbers.Where(n => n > 1).Select(n => strings[n] + " ~• ");
            foreach (var s in selectsss)
            {
                Console.Write(s);
            }
        }

        public static void sample4()
        {
            // use Anonymous type constructor to construct multivalue reuslt 
            var q = strings.Select(ss => new { Head = ss.Substring(0, 1), Tail = ss.Substring(1) });
            foreach (var p in q)
            {
                Console.WriteLine(p.Head + "---" + p.Tail);
            }
        }

        public static void sample5()
        {
            var query = numbers.Where(n => n > 5).Select(n => strings[n]);
            foreach (var q in query)
            {
                Console.WriteLine(q);
            }
        }

        public static void sample6()
        {
            int i = 0;
            var q = numbers.Select(n => ++i);
            foreach (var s in q)
            {
                Console.WriteLine(s + " - " + i);
            }
        }

        public static void sample7()
        {

            var q = strings.GroupBy(s => s[0]); // <- group by first character of each string

            foreach (var g in q)
            {
                Console.WriteLine("Group: {0}", g.Key);
                foreach (string v in g)
                {
                    Console.WriteLine("\tValue: {0}", v);
                }
            }

        }
        public static void Sample8()
        {
            // use GroupBy() and aggregates such as Count(), Min(), Max(), Sum(), Average() to compute values over a partition
            var q = strings.GroupBy(s => s[0]).Select(g => new { FirstChar = g.Key, Count = g.Count() });

            foreach (var v in q)
            {
                Console.WriteLine("There are {0} string(s) starting with the letter {1}", v.Count, v.FirstChar);
            }
        }
        public static void Sample9()
        {
            // use OrderBy()/OrderByDescending() to give order to your resulting sequence
            var q = strings.OrderBy(s => s);  // order the strings by their name

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
        }

        public static void Sample9a()
        {
            // use ThenBy()/ThenByDescending() to provide additional ordering detail
            var q = persons.OrderBy(p => p.Level).ThenBy(p => p.Name);

            foreach (var p in q)
            {
                Console.WriteLine("{0}  {1}", p.Level, p.Name);
            }
        }

        public static void Sample10()
        {
            // use query expressions to simplify
            var q = from p in persons
                    orderby p.Level, p.Name
                    group p.Name by p.Level into g
                    select new { Level = g.Key, Persons = g };

            foreach (var g in q)
            {
                Console.WriteLine("Level: {0}", g.Level);
                foreach (var p in g.Persons)
                {
                    Console.WriteLine("Person: {0}", p);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample.sample1();
            Sample.sample2();
            Sample.sample3();
            Sample.sample4();
            Sample.sample5();
            Sample.sample6();
            Sample.sample7();
            Sample.Sample8();

        }
    }
}
