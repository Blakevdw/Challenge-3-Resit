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
	public class UsedRoomController : ApiController
	{
		public UsedRooms Get(string id)
		{
			SqlConnection conn;
			SqlCommand cmd;
			SqlDataReader rdr;
			UsedRooms output = new UsedRooms();
			conn = DBconnect.Connect();
			string qeury = "select * from Room Where RoomCapacity = '" + 0 + "'";

			try
			{
				conn.Open();

				cmd = new SqlCommand(qeury, conn);

				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					output = new UsedRooms(Convert.ToString((rdr.GetValue(0).ToString())), Convert.ToInt32(rdr.GetValue(1)),
						Convert.ToInt32(rdr.GetValue(2)));
				}
				rdr.Close();

				rdr = cmd.ExecuteReader();

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
