using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tukhoa
{
    // typeof ( ): Takes a type name when compile time
    // GetType(): Return type when run time 
    // is : return true if an instance is in the inheritance tree
    /*
     class Animal { } 
class Dog : Animal { }

void PrintTypes(Animal a) { 
    print(a.GetType() == typeof(Animal)) // false 
    print(a is Animal)                   // true 
    print(a.GetType() == typeof(Dog))    // true
}

Dog spot = new Dog(); 
PrintTypes(spot);
     */


    /*
     I've seen many people use the following code:

            Type t = typeof(obj1);
            if (t == typeof(int))
                // Some code here
    But I know you could also do this:

            if (obj1.GetType() == typeof(int))
                // Some code here
    Or this:

            if (obj1 is int)
                // Some code here
    Personally, I feel the last one is the cleanest, but is there something I'm missing? Which one is the best to use, or is it personal preference?
     
     */
    class Animal
    {
        public string Name { get; set; }

    }
    class Dog : Animal
    {

    }
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Animal a = new Animal();
            if(a.GetType() == typeof(Animal))
            {
                Console.WriteLine("Get is of");
                Console.WriteLine(a.GetType().Name);
            }
            else
            {
                Console.WriteLine("Get not of");
            }
           // use is 
            Console.WriteLine(a is Animal);
            Console.WriteLine(a.GetType() == typeof(Dog));

            Dog b = new Dog();
            Console.WriteLine(b.GetType());
            Console.WriteLine(typeof(Dog));

        }
    }
}
