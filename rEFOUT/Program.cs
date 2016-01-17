using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rEFOUT
{
    class Program
    {
        public static void Main(string[] args)
        {
            int y = 5; // REF TRUYEN THAM CHIEU, KHAC OUT MOI CHO REF CAN KHOI TAO GIA TRI CHO BIEN TRUOC 
            int z;  // DUNG OUT DE TRUYEN THAM CHIEU, KHAC REF MOI CHO OUT KO CAN KHOI TAO DOI TUONG


            Console.WriteLine("Original value of y: {0}", y);  // 5
            Console.WriteLine("Original value of z: uninitialized\n");

            SquareRef(ref y); // y =Y*Y = 25
            SquareOut(out z);  // VAO HAM MOI KHOI TAO GIA TRI Z = 6 VA 6*6

            Console.WriteLine("Value of y after SquareRef: {0}", y); //25
            Console.WriteLine("Value of z after SquareOut: {0}\n", z); // 36

            Square(y); // GIA TRI CU CUA Y LA 25 VA HAM NAY THI Y*Y NHUNG DO TRUYEN THAM TRI LEN GIA TRI SAU KHI RA KHOI HAM KHONG BI TAHY DOI, TUC LA Y VAN BANG 25
            Square(z); // TUONG TU CHO z


            Console.WriteLine("Value of y after Square: {0}", y);
            Console.WriteLine("Value of z after Square: {0}", z);


            //== 
            int[] array = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

            Console.WriteLine("Grade distribution:");
            for (int counter = 0; counter < array.Length; counter++)
            {
                if (counter == 10)
                    Console.Write("  100: ");
                else
                    Console.Write("{0:D2}-{1:D2}: ",
                        counter * 10, counter * 10 + 9);

                // display bar of asterisks
                for (int stars = 0; stars < array[counter]; stars++)
                    Console.Write("*");
            }
        }

        static void SquareRef(ref int x)
        {
            x = x * x; // squares value of caller's variable
        }

        static void SquareOut(out int x)
        {
            x = 6;
            x = x * x;
        }

        static void Square(int x)
        {
            x = x * x;
        }


    }
}
