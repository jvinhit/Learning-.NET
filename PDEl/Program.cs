using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDEl
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        // Khai bao 1 delegate tra ve kieu bool co tham so turyen vao la 1 object person

        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // Tao ra 4 Person object
            Person p1 = new Person() { Name = "Vinh", Age = 23 };
            Person p2 = new Person() { Name = "Thuy", Age = 21 };
            Person p3 = new Person() { Name = "Thao", Age = 22 };
            Person p4 = new Person() { Name = "Trang", Age = 10};
            Person p5 = new Person() { Name = "Tuyen", Age = 67 };
            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { p1, p2, p3, p4,p5 };
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);

            Console.Read();

        }

        static void DisplayPeople(string title,List<Person> people,FilterDelegate del)
        {
            Console.WriteLine(title);
            foreach(Person p in people)
            {
                if (del(p))
                {
                    Console.WriteLine("\t{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        /// Method filter
        /// 
        static bool IsChild(Person p)
        {
            return p.Age <= 18;

        }
        static bool IsAdult(Person p)
        {
            return p.Age > 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
