using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccess
{
    public class Login
    {
        public static string Connection
        {
            get { return "Data Source=ping-pc;Initial Catalog=NORTHWND;Integrated Security=True"; }
        }
    }
}
