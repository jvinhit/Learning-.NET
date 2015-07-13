using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class SimpleDatasetSQL
    {
        public static void haha()
        {
            string source = Login.Connection;
            string select = "SELECT ContactName,CompanyName FROM Customers";

            using (SqlConnection conn = new SqlConnection(source))
            {
                SqlDataAdapter da = new SqlDataAdapter(select, conn);

                DataSet ds = new DataSet();

                da.Fill(ds, "Customers");

                foreach (DataRow row in ds.Tables["Customers"].Rows)
                    Console.WriteLine("'{0}' from {1}",
                        row[0],
                        row[1]);

                conn.Close();
            }
        }
    }
}
