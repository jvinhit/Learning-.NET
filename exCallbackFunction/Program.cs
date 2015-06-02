using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exCallbackFunction
{
    public delegate void DelTangQua(string qua);
    public class PerSon
    {
        public string Name { get; set; }
        public void tangQua(string qua)
        {
            Console.WriteLine("Da tang " + qua);
        }
        public void XacThuc(PerSon vo, DelTangQua tangQuas)
        {
            Console.WriteLine(vo.Name+" da tang Qua");
            var qua = "DA nhan Qua ";
            tangQuas(qua);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PerSon p = new PerSon()
            {
                Name
                    = "Thao"
            };
            DelTangQua d = new DelTangQua(p.tangQua);
            p.XacThuc(p, d);
        }
    }
}
