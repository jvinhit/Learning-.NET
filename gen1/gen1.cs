using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gen1
{
    public class Pair<T, U>
    {
        public T First { get; set; }
        public U Seconds { get; set; }
        public override string ToString()
        {
            return "{ " + First + "," + Seconds + " }";
        }

    }
    public class MyList<T>
    {
        T[] ints = new T[3];
        int currentIndex;
        public void ADD(T item)
        {
            if (currentIndex == ints.Length)
            {
                Grows();
            }
            ints[currentIndex++] = item;
        }
        public T Get(int index)
        {
            return
                ints[index];
        }

        private void Grows()
        {
            T[] temp = new T[ints.Length * 2];
            Array.Copy(ints, temp, ints.Length);
            ints = temp;
        }
        public int GetLeght
        {
            get
            {
                return ints.Length;
            }
        }
    }

    class gen1
    {
        static void DosomeThing<T>(T args)
        {
            Console.WriteLine(args.GetType());
        }
        static void Main(string[] args)
        {
            Pair<int, int> p1 = new Pair<int, int> { First = 1, Seconds = 2 };
            Console.WriteLine(p1.ToString());
            Pair<string, string> p2 = new Pair<string, string> { First = "Vinh", Seconds = "Thao" };
            Console.WriteLine(p2.ToString());
            int args2 = 1;
            DosomeThing(args2);
        }
       
   
     }
}
