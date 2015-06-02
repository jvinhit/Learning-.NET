using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actionss
{
    delegate int congTru ( int a, int b);
    class actionsDemo
    {
        // Action la delegate co kieu tra ve la void va de thuc hien 1 hanh dong nao do voi tham so ma ta truyen vao 
        static void actionThemPhanTuVaoMang(Action<int []> action, int [] a)
        {
            action(a);
        }
        static void nhapmang(int [] a,int n)
        {
            Console.WriteLine("Nhap vao so phan tu cua mang");
            a = new int[] { 1, 2, 3, 4 };
            foreach(var ass in a)
            {
                Console.WriteLine(ass);
            }
        }
        // Tham so cua ham co kieu T . Thuc hien Action tren kieu du lieu T nay
        static void ThucHienAction<T>(Action<T> action, T parameter)
        {
            action(parameter);
        }
        static void Cong (Action<int> action , int a, int b)
        {
             action(a + b);
        }
        static void Nhapa(int a)
        {
            a = int.Parse(Console.ReadLine());
          
        }

       
       
        static void Main(string[] args)
        {

            ThucHienAction(ACtionss, 30);
            Cong(Console.WriteLine, 10, 20);
            // delegat
            //Func<int, int, string> lamds = (x, y) =>
            //    {
            //        var result = (x + y).ToString();
            //        return result;
            //    };
            //Console.WriteLine(lamds(10, 20));
            //int [] mangso =  {1,2,3,4,5,6};
            //Console.WriteLine(mangso.Min());
        }
        static void ACtionss(int a )
        {
           
            Console.WriteLine(a*3);
        }
    }
}
