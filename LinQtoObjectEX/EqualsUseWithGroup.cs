using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoObjectEX
{
    /*interface IqualityCompare: 
        bool Equals(T x, T y);
        int GethashCode(T obj);
     */
    public class SoundexEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return GetHashCode(x) == GetHashCode(y);
        }
        public int GetHashCode(string obj)
        {
            // E.g convert Soundex code A123 to an integer :65123
            int result = 0;
            string s = soundex(obj);
            if (string.IsNullOrEmpty(s) == false)
                result = Convert.ToInt32(s[0]) * 1000 +
                Convert.ToInt32(s.Substring(1, 3));
            return result;

        }

        private string soundex(string obj)
        {
            // Algorithm as listed on
            // http://en.wikipedia.org/wiki/Soundex.
            // builds a string code in the format:
            // [A-Z][0-6][0-6][0-6]
            // based on the phonetic sound of the input.
            if (String.IsNullOrEmpty(obj))
                return null;
            StringBuilder result = new StringBuilder(obj.Length);
            // As long as there is at least one character, then we can proceed
            string source = obj.ToUpper().Replace(" ", "");
            // add the first character, then loop the
            // string mapping as we go
            result.Append(source[0]);
            char previous = '0';
            for (int i = 1; i < source.Length; i++)
            {
                // map to the soundex numeral
                char mappedTo = '0';
                char thisChar = source[i];
                if ("BFPV".Contains(thisChar))
                    mappedTo = '1';
                else if ("CGJKQSXZ".Contains(thisChar))
                    mappedTo = '2';
                else if ("DT".Contains(thisChar))
                    mappedTo = '3';
                else if ('L' == thisChar)
                    mappedTo = '4';
                else if ("MN".Contains(thisChar))
                    mappedTo = '5';
                else if ('R' == thisChar)
                    mappedTo = '6';
                // ignore adjacent duplicates and
                // non-matched characters
                if (mappedTo != previous && mappedTo != '0')
                {
                    result.Append(mappedTo);
                    previous = mappedTo;
                }
            }
            while (result.Length < 4) result.Append("0");
            return result.ToString(0, 4);
        }

    }
    class EqualsUseWithGroup
    {
        public static void ex19()
        {
            string[] names = new string[] { "Janet" , "Janette" , "Joanne" ,
"Jo-anne" , "Johanne" , "Katy" , "Katie" , "Ralph" , "Ralphe" };
            var q = names.GroupBy(s => s,
            new SoundexEqualityComparer());
            foreach (var group in q)
            {
                Console.WriteLine(group.Key);
                foreach (var name in group)
                    Console.WriteLine(" - {0}", name);
            }
        }
    }
}
