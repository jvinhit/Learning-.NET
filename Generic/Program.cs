using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Generic
{
    public class NhieuKieu<T> :IEnumerable<T>
    {
        T[] MangT = new T[5];
        int count = 0;
        public void AdDD(T item)
        {
            if (count == MangT.Length)
            {
                Array.Resize(ref MangT, MangT.Length * 2);
            }
            MangT[count++] = item;
        }

        // Using Ienumerable -> return Ienumerator (GetEnumerator)

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i=0 ; i< count; i++)
                yield return MangT[i];
        }

        public void inRA( T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NhieuKieu<int> kieuint = new NhieuKieu<int>();
            Console.WriteLine((kieuint is int).ToString());
            kieuint.AdDD(10);
            kieuint.AdDD(2);
            foreach(var n in kieuint)
            {
                Console.WriteLine(n);
            }
        }
    }
}
