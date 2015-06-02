using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restrictdataWhereclause
{
    class menhdeWhere
    {
        static void Main(string[] args)
        {
            string[] animals = new string[]{
                "Vinh","Thuy","Thao","Huong","Duyen","Nhu y"
            };
         
            //IEnumerable<string> kq = animals.Where(a => a.StartsWith("V")&& a.Length > 2);
            //Filter by index position
            IEnumerable<string> kq = animals.Where((a,index)=> index%2 ==0);

            //foreach(string s in kq)
            //{
            //    Console.WriteLine(s);
            //}
            // use selectmany : 
            string[] sentence = new string[] { "tinh yeu mau nang", "khi co don em nho ai", "noi buon chim da da" };
            Console.WriteLine("- Option 1:");
            Console.WriteLine("----------");
            IEnumerable<string[]> option1 = sentence.Select(w => w.Split(' '));
            Console.WriteLine(option1.Count());
            foreach (string[] segment in option1)
            {

                foreach(string chan in segment)
                {

                    Console.WriteLine(chan);

                }
            }
            Console.WriteLine();
            Console.WriteLine("Option 2:");
            IEnumerable<string> option2 = sentence.SelectMany(x => x.Split(' '));
            Console.WriteLine(option2.Count());
        
            // query expression 
            var vinh = from t in sentence
                       from word in t.Split(' ')
                       select word;


            /// How to get index position of the result
            /// 
            
        }
    }
}
