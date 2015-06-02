using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    /// <summary>
    ///  Kiểu T sau này sẽ được gọi cụ thể 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T>
    {
        T[] items = new T[5];
        int currentIdenx;
        public void add(T item)
        {
            if (currentIdenx == items.Length)
            {
                RezieT();
            }
            items[currentIdenx++] = item;
        }

        private void RezieT()
        {
            T[] temp = new T[items.Length + 1];
            Array.Copy(items, temp, items.Length);
            items = temp;
        }
    }
    class Program
    {

        private static void PrintT<T>(T item)
        {
            Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            MyList<int> listInts = new MyList<int>();
            listInts.add(10);
            listInts.add(10);
            listInts.add(10);
            listInts.add(10);
            listInts.add(10);
            listInts.add(10);
            PrintT<int>(10);
        }
    }
}
