using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class ClassC
    {
        private readonly IClassA ma;
        private readonly IClassB mb;
        public ClassC(IClassA a, IClassB b)
        {

            this.ma = a;
            this.mb = b;
        }
    }
}
