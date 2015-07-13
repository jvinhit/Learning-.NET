using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataReaderSql
    {
        public static int haha()
        {
            string source = Login.Connection;

            string select = "SELECT ContactName,CompanyName FROM Customers";

            SqlConnection conn = new SqlConnection(source);

            try
            {
                using (conn)
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(select, conn);

                    using (SqlDataReader aReader = cmd.ExecuteReader())
                    {
                        while (aReader.Read())
                            Console.WriteLine("'{0}' from {1}", aReader.GetString(0), aReader.GetString(1));

                        aReader.Close();
                    }

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
                Console.WriteLine("Chances are your database does not have a user");
                Console.WriteLine("called QSUser, or you do not have the NetSDK database installed.");
            }

            return 0;
        }
    }

}
