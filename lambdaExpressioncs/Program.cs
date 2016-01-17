using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExpressioncs
{
    class Program
    {
        public delegate bool NumberPredicate(int number);
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            NumberPredicate eventPredicate = number => number % 2 == 0;
            // Hay con co the viet 
                    //eventPredicate = delegate(int number)
                    //{
                    //    return number % 2 == 0;
                    //};

            Console.WriteLine("Loc chan : {0}",eventPredicate(4));

            List<int> eventNumbers = FilterArray(numbers, eventPredicate);
            Display("Use lambda: ",eventNumbers);


            List<int> oodNumber = FilterArray(numbers, (int nums) => nums%2 == 1);
            Display("Odd ecc: ", oodNumber);


        }

        static List<int> FilterArray(int[] arrays, NumberPredicate filter)
        {
            List<int> result = new List<int>();
            foreach (var item in arrays)
            {
                if(filter(item))
                    result.Add(item);
            }
            return result;
        }

        static void Display(string decription, List<int> list)
        {
            Console.Write(decription);
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
