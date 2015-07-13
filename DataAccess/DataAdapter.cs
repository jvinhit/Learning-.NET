using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAdapter
    {
        /// <summary>
        /// DataAdapter - show Stored Proc and DataAdapter
        /// </summary>
        public static void haha()
        {
            // The following is the database connection string
            string source = Login.Connection;

            // Create & open the database connection
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();

                // Create a DataSet
                DataSet ds = new DataSet();

                // Create a data adapter to fill the DataSet
                SqlDataAdapter da = new SqlDataAdapter();

                // Set the data adapters select co
                da.SelectCommand = GenerateSelectCommand(conn);

                da.Fill(ds, "Region");

                // Now loop through rows in the region table...
                Console.WriteLine("Data selected via a stored procedure");

                foreach (DataRow aRow in ds.Tables["Region"].Rows)
                {
                    Console.WriteLine("  {0,-3} {1}", aRow[0], aRow[1]);
                }

                conn.Close();
            }
        }

        /// <summary>
        /// Create a command that will select all region records
        /// </summary>
        /// <param name="conn">The database connection</param>
        /// <returns>A SqlCommand</returns>
        private static SqlCommand GenerateSelectCommand(SqlConnection conn)
        {
            SqlCommand aCommand = new SqlCommand("RegionSelect", conn);

            aCommand.CommandType = CommandType.StoredProcedure;
            aCommand.UpdatedRowSource = UpdateRowSource.None;

            return aCommand;
        }

    }
}

/*StoreProc.sql
 --
-- Procedure to select all rows from the Region table
--
CREATE PROCEDURE RegionSelect AS
  SET NOCOUNT OFF;

  SELECT * FROM Region ;
GO

 */