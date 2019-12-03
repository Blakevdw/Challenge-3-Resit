using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_Challenge_3_Resit
{
	public static class DBconnect
	{

		public static SqlConnection Connect()
		{
			string ConnString = @"server = civapi.database.windows.net; 
                Database=civapi; User Id=civ_user;Password=Monday1330";

			return new SqlConnection(ConnString);
		}

	}
}