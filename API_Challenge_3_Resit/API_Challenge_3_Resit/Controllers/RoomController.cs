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
	public class RoomController : ApiController
	{

		// GET ALL api/Room
		public IEnumerable<Room> Get()
		{
			SqlConnection conn = DBconnect.Connect();
			SqlCommand cmd;
			SqlDataReader rdr;
			String query;
			List<Room> output = new List<Room>();


			try
			{
				conn.Open();


				query = "select * from Room";
				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output.Add(new Room(Convert.ToString(rdr.GetValue(0)), Convert.ToInt32(rdr.GetValue(1)), Convert.ToInt32(rdr.GetValue(2))));
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


		// GET ALL api/Room/Computers
		public RoomWComputer Get(string id)
		{
			SqlConnection conn;
			SqlCommand cmd;
			SqlDataReader rdr;
			RoomWComputer output = new RoomWComputer();
			conn = DBconnect.Connect();
			string qeury = "select* from Room Where id = '" + id + "'";
			string qeuryBook = "select * from Computer where Room = " + id + "'"; 

			try
			{
				conn.Open();

				cmd = new SqlCommand(qeury, conn);

				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					output = new RoomWComputer(Convert.ToString((rdr.GetValue(0).ToString())), Convert.ToInt32(rdr.GetValue(1)),
						Convert.ToInt32(rdr.GetValue(2)));
				}
				rdr.Close();

				cmd.CommandText = qeuryBook;

				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					output.computers.Add(new Computer(Convert.ToInt32(rdr.GetValue(0).ToString()), Convert.ToInt32(rdr.GetValue(1)),
						Convert.ToString(rdr.GetValue(2)), Convert.ToInt32(rdr.GetValue(3))));

				}

			}

			catch (Exception e)
			{
				throw e;
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

