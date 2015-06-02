using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{

    partial class clsCommon
    {
        int i = 10;
        int j = 20;
        public int sum()
        {
            return i + j;
        }
    }

}
