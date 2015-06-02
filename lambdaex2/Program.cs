using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaex2
{

    static class Program
    {

        public static bool Loc(this int x)
        {
            return x > 5;
        }
        static bool LocChan(int x)
        {
            return x % 2 == 0;
        }
        static void Mains()
        {
            

        }
        static void Main()
        {
            List<int> listint = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Anonymous method
            //var mangsochan = listint.FindAll(delegate(int x)
            //{
            //    return x % 2 == 0;
            //});
            //lambda
            var mangsochan = listint.FindAll(x => x % 2 == 0);
            // REmove x > 5 
            var mangnhohon5
                //= listint.RemoveAll(x => x > 5);
            /// 
                = listint.RemoveAll(Loc);
            
            // Extension
            //listint.FindAll(LocChan);

            foreach(var x in mangsochan)
            {
                Console.WriteLine(x);
            }

            // using delegate Func
            Func<int, int, string> intToString = 
                // Using lambda : (x, y) => (x + y).ToString();
                // Using anonymous : 
                delegate (int  x, int y)
                {
                    return (x+y).ToString();
                };

            Func<int, int> oneParam = x => x + 2 ;
            Console.WriteLine(intToString(10, 20));
            Predicate<int> kiemtra = x => x > 5;
            Func<string, int> demsotu = delegate(string s)
            {
                return s.Length;
            };

            Console.WriteLine("Dem so tu : "+ demsotu("Nguyen Van Vinh"));

            List<int> myList = new List<int>{
                1,2,3,4,5,6};
            IEnumerator<int> getIE = myList.GetEnumerator();
            while(getIE.MoveNext())
            {
                Console.WriteLine(getIE.Current);
            }

        }
    }
}
