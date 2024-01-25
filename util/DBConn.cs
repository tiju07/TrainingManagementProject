using Microsoft.Data.SqlClient;
using System.Configuration;

namespace TrainingMangementConsole.util
{
	public static class DBConn
	{
		public static string connString = ConfigurationManager.AppSettings.Get("DefaultConnection");

		public static SqlConnection ReturnConnectionObject()
		{
			SqlConnection conn = new SqlConnection(DBConn.connString);
			return conn;
		}
	}
}
