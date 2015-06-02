using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DelegateO
{
    class delegateCB
    {
        static FileStream FStream;
        static StreamWriter SWriter;

        // define delegate
        public delegate void PrintData(String source);
        // Method to print console
        public static void WriteConsole(string str)
        {
            Console.WriteLine("{0} - Console", str);
        }

        public static void WriteFile(string src)
        {
            Console.WriteLine("{0} WriteFile", src);
            FStream = new FileStream("D:\\StoreData.txt",FileMode.Append,FileAccess.Write);
            SWriter = new StreamWriter(FStream);
            src = src + " File";
            SWriter.WriteLine(src);
            // removing content from buffer
            SWriter.Flush();
            SWriter.Close();
            FStream.Close();
          
            
        }

        // Method sent the string data to respective method
        public static void DisplayData(PrintData PMethod)
        {
            PMethod("Noi dung ghi len ");
        }
        static void Main(string[] args)
        {
            // Delegate CN [void(string)] xẽ đóng gói phương thức WriteConsole
            PrintData CN = new PrintData(WriteConsole);
            // Thực thi delegate bằng cách gọi Invoke (parameteer). Vậy tham số trong invoke chính là tham số của WriteConsole
            CN.Invoke("Noi dung ");
            //=============Single-Cast Delegate====
            // Initializing Delegate object
            ////PrintData Cn = new PrintData(WriteConsole);
            ////PrintData Fl = new PrintData(WriteFile);
            ////// invoke the DisplayData method with the Delegate object as argument
            ////DisplayData(Cn);
            ////DisplayData(Fl);
            ////Console.ReadLine();
            //=============Multi-Cast Delegate====
            PrintData Muldel = new PrintData(WriteConsole);
            Muldel += new PrintData(WriteFile);
            DisplayData(Muldel);
            //Muldel -= new PrintData(WriteConsole);
            //DisplayData(Muldel);
            //=== 




        }
    }
}
