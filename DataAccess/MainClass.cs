using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class MainClass
    {
        public static void Main()
        {

            string Source = Login.Connection;
            //ExecuteCommand.ExcuteSql(Source);
            //ExecuteCommand.ExecuteStoreProc(Source);
            //ExecuteCommand.ExecuteFullTable(Source);
            //ExecuteCommand.ExecuteBatch(Source);
            ExecuteCommand.ExecuteXml(Source);
        }
    }
}
