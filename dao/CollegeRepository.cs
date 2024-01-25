using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingMangementConsole.util;

namespace TrainingMangementConsole.dao
{
	public class CollegeRepository : ICollegeRepository
	{
		SqlConnection conn = null;
		SqlCommand cmd = null;
		SqlDataReader dr = null;
		public void GetAllColleges()
		{
			using (conn = DBConn.ReturnConnectionObject())
			{
				conn.Open();
				cmd = new SqlCommand("spColleges", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				dr = cmd.ExecuteReader();
				var columns = Enumerable.Range(0, dr.FieldCount).Select(dr.GetName).ToList();
				while (dr.Read())
				{
					var data = Enumerable.Range(0, dr.FieldCount).Select(dr.GetValue).ToList();
                    for (int i = 0; i < columns.Count; i++)
					{
						Console.WriteLine($"{columns[i]} : {data[i]}");
                    }
                    Console.WriteLine(new String('-', 50));
                }
			}
		}

		public void GetCollegeByID(int CollegeId)
		{
			throw new NotImplementedException();
		}

		public void InsertCollege(CollegeRepository college)
		{
			throw new NotImplementedException();
		}
	}
}
