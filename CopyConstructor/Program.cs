using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // instance constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        // Copy Constructor
        public Person(Person p)
        {
            Name = p.Name;
            Age = p.Age;
        }

        public override string ToString()
        {
            return Name +" is "+ Age.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Tao person su dung constructor instance
            Person personInstance = new Person("Vinh", 20);
            // Tao ra 1 person khac copy thuoc tinh cua person 1
            Person personCopy = new Person(personInstance);

            // Change each person's age
            personInstance.Age = 30;
            personCopy.Age = 28;
            // Changed PersonCopy Name;
            personCopy.Name = "THuy";
            // Show tostring
            Console.WriteLine(personInstance.ToString());
            Console.WriteLine(personCopy.ToString());
            Console.WriteLine(personInstance.ToString());
            

        }
    }
}
