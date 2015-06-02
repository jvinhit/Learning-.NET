using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 LambdaEXpression thuc chat la 1 anonynous  function.
 * the left => the right
 * với left là một tham số đầu vào
 * right là một extentions hay 1 statetment
 * ví dụ : 
 
 */



namespace lambdaEX
{

    /// <summary>
    ///  
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> so = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //List<int> sochan = so.FindAll(x => (x % 2 == 0));
            //foreach (int soChan in sochan)
            //{
            //    Console.WriteLine(soChan);
            //}
            List<int> list = new List<int>() { 20, 1, 4, 8, 9, 44 };

            // Process each argument with code statements
            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("value of i is: {0}", i);
                return (i % 2) == 0;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int even in evenNumbers)
                Console.Write("{0}\t", even);

        }
    }
}
