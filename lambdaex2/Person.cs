using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaex2
{
    public delegate int Dem(IEnumerable<Person> person);

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DoB { get; set; }

        public override string ToString()
        {
            return "ten: " + Name + " tuoi: " + Age + " NgaySinh: " + DoB;
        }

        public static List<Person> SameData()
        {
            List<Person> personList = new List<Person> 
            {
                new Person { Name="Vinh" ,Age = 24,DoB= new DateTime(1991,05,24)},
                new Person { Name ="Thuy", Age=23,DoB=new DateTime(1992,08,20)},
                new Person { Name ="Minh", Age=25, DoB = new DateTime(1991,2,22)},
                new Person {    Name = "Truyen", Age= 26, DoB=new DateTime(1990,2,23)}
            };

            return personList;
        }
       
    }
}
