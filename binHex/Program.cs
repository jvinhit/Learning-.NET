using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binHex
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static byte[] Hex2Bin(string hex)
        {
            if (hex == null || hex.Length < 1)
            {
                return new byte[0];
            }
            int num = hex.Length/2;
            byte[] buffer =new byte[num];
            num *= 2;
            for (int i = 0; i < num; i++)
            {
                int num3 = int.Parse(hex.Substring(i, 2), NumberStyles.HexNumber);
                buffer[i / 2] = (byte)num3;
                i++;
            }
            return buffer;
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
