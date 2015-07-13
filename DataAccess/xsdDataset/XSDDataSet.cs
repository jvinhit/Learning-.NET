using System;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

public class XSD_DataSet
{
	public static void haha ( )
	{
		string        source = Login.Connection ;
		string        select = "SELECT * FROM Products" ;

		using ( SqlConnection  conn = new SqlConnection ( source ) )
		{
			SqlDataAdapter da = new SqlDataAdapter ( select , conn ) ;

			Products      ds = new Products ( ) ;

			da.Fill ( ds , "Product" ) ;

			foreach ( Products.ProductRow row in ds.Product )
				Console.WriteLine ( "'{0}' from {1}" , 
					row.ProductID ,
					row.ProductName ) ;

			conn.Close ( ) ;
		}
	}
}