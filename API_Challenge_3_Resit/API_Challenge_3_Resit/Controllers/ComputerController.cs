﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using API_Challenge_3_Resit;
using API_Challenge_3_Resit.Models;

namespace API_Challenge_3_Resit.Controllers
{
    public class ComputerController : ApiController
    {

		// GET ALL api/Computer
		public IEnumerable<Computer> Get()
		{
			SqlConnection conn = DBconnect.Connect();
			SqlCommand cmd;
			SqlDataReader rdr;
			String query;
			List<Computer> output = new List<Computer>();


			try
			{
				conn.Open();


				query = "select * from Computer";
				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output.Add(new Computer(Convert.ToInt32(rdr.GetValue(0)), Convert.ToInt32(rdr.GetValue(1)), Convert.ToString(rdr.GetValue(2)), Convert.ToInt32(rdr.GetValue(3))));
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

