using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Xml;

namespace DataAccess
{
    class ExecuteCommand
    {

        public static void ExcuteSql(string source)
        {
            string select = "Select  ContactName, CompanyName From Customers";
            try
            {
                using (SqlConnection conn = new SqlConnection(source))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(select, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("*** SqlProvider ***");
                        Console.WriteLine("Output from direct SQL statement...");
                        Console.WriteLine();
                        Console.WriteLine("CONTACT                        COMPANY");
                        Console.WriteLine("---------------------------------------------------------------------");

                        // And iterate through the data
                        while (reader.Read())
                        {
                            Console.WriteLine("{0,-30} {1}", reader[0], reader[1]);
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Loi : " + e.ToString());
            }
        }

        public static void ExecuteStoreProc(string source)
        {
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("CustOrderHist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CustomerID", "Quick");
                //DataReader
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("");
                    Console.WriteLine("*** SqlProvider ***");
                    Console.WriteLine("Call NorthWind CustOrderHist stored proc for customer 'QUICK'...");
                    Console.WriteLine();
                    Console.WriteLine("Product Name                       Quantity");
                    Console.WriteLine("---------------------------------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine("{0,-34} {1}", reader[0], reader[1]);
                    }

                    reader.Close();

                    Console.WriteLine();
                    // Close the connection
                    conn.Close();
                }

            }
        }

        public  static void ExecuteFullTable(string source)
        {
            // Connect to the database...
            using (OleDbConnection conn = new OleDbConnection("Provider=SQLOLEDB;" + source))
            {
                // Open the database connection
                conn.Open();

                // Create the SQL command that links to a stored procedure
                OleDbCommand cmd = new OleDbCommand("Categories", conn);

                // Set the type to TableDirect
                cmd.CommandType = CommandType.TableDirect;

                // Construct the data reader
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("");
                    Console.WriteLine("*** OleDbProvider ***");
                    Console.WriteLine("Listing all records in Categories table...");
                    Console.WriteLine();
                    Console.WriteLine("ID  Name            Description");
                    Console.WriteLine("---------------------------------------------------------------------");

                    // Iterate through the data
                    while (reader.Read())
                    {
                        Console.WriteLine("{0,-3} {1,-15} {2}", reader[0], reader[1], reader[2]);
                    }

                    reader.Close();

                    Console.WriteLine();
                }

                // Close the connection
                conn.Close();
            }
        }

        public  static void ExecuteBatch(string source)
        {
            string select = "SELECT COUNT(*) FROM Customers;SELECT COUNT(*) FROM Products";

            // Connect to the database...
            using (SqlConnection conn = new SqlConnection(source))
            {
                // Open the database connection
                conn.Open();

                // Create the SQL command...
                SqlCommand cmd = new SqlCommand(select, conn);

                // Construct the data reader
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Output headings...
                    Console.WriteLine("*** SqlProvider ***");
                    Console.WriteLine("Output from batched SQL statements");
                    Console.WriteLine();

                    int statement = 0;

                    do
                    {
                        statement++;

                        while (reader.Read())
                        {
                            Console.WriteLine("Output from batch statement {0} is {1}", statement, reader[0]);
                        }
                    } while (reader.NextResult());

                    reader.Close();
                }

                conn.Close();
            }
        }

        public  static void ExecuteXml(string source)
        {
            string select = "SELECT ContactName,CompanyName FROM Customers FOR XML AUTO";

            using (SqlConnection conn = new SqlConnection(source))
            {
                // Open the database connection
                conn.Open();

                // Create the SQL command...
                SqlCommand cmd = new SqlCommand(select, conn);

                // Construct an Xml Reader
                XmlReader xr = cmd.ExecuteXmlReader();

                Console.WriteLine("");
                Console.WriteLine("*** SqlProvider ***");
                Console.WriteLine("Use ExecuteXmlReader with a FOR XML AUTO SQL clause");
                Console.WriteLine();

                // Do something useful with the xml
                while (xr.Read())
                {
                    Console.WriteLine(xr.ReadOuterXml());
                }

                // And close the connection
                conn.Close();
            }
        }
    }

}
