using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq2
{

    public class CountOccurentceWord
    {
        public void Test()
        {
            string chuoi = @"Historically, the world of data and the world of objects" +
            @" have not been well integrated. Programmers work in C# or Visual Basic" +
            @" and also in SQL or XQuery. On the one side are concepts such as classes," +
            @" objects, fields, inheritance, and .NET Framework APIs. On the other side" +
            @" are tables, columns, rows, nodes, and separate languages for dealing with" +
            @" them. Data types often require translation between the two worlds; there are" +
            @" different standard functions. Because the object world has no notion of query, a" +
            @" query can only be represented as a string without compile-time type checking or" +
            @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
            @" objects in memory is often tedious and error-prone.";
            string searchTerm = "data";
            string[] source = chuoi.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var matchQuery =
            from word in source
            where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
            select word;

            int wordCount = matchQuery.Count();
            Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.",
                wordCount, searchTerm);
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            CountOccurentceWord cs = new CountOccurentceWord();
            cs.Test();
        }
    }

}
