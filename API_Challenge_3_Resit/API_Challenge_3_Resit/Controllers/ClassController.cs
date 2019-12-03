using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using API_Challenge_3_Resit;
using API_Challenge_3_Resit.Models;
namespace API_Challenge_3_Resit.Controllers
{
	public class ClassController : ApiController
	{
		// GET ALL api/Class
		public IEnumerable<Class> Get()
		{
			SqlConnection conn = DBconnect.Connect();
			SqlCommand cmd;
			SqlDataReader rdr;
			String query;
			List<Class> output = new List<Class>();


			try
			{
				conn.Open();


				query = "select * from Class";
				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output.Add(new Class(Convert.ToString(rdr.GetValue(0)), Convert.ToString(rdr.GetValue(1)), Convert.ToString(rdr.GetValue(2)), Convert.ToInt32(rdr.GetValue(3))));
				}
			}

			catch (Exception e)
			{
				throw;
			}
			finally
			{
				if (conn.State == System.Data.ConnectionState.Open)
				{
					conn.Close();
				}
			}

			return output;

		}

		// GET api/Class/{ClassCode}

		public Class Get(int id)
		{
			SqlConnection conn = DBconnect.Connect();

			string query = "select * from Class where ClassCode = " + id;
			Class output = new Class();
			SqlCommand cmd;
			SqlDataReader rdr;

			try
			{
				conn.Open();

				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output = (new Class(Convert.ToString(rdr.GetValue(0)), Convert.ToString(rdr.GetValue(1)), Convert.ToString(rdr.GetValue(2)), Convert.ToInt32(rdr.GetValue(3))));

				}
			}
			catch (Exception e)
			{
				throw;
			}
			finally
			{
				if (conn.State == System.Data.ConnectionState.Open)
				{
					conn.Close();
				}
			}

			return output;

		}

	}
}