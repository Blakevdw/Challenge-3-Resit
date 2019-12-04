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
		public IEnumerable<UsedRooms> Get()
		{
			List<UsedRooms> output = new List<UsedRooms>();
			LibDataSetTableAdapters.BooksBorrowedTableAdapter ta = new LibDataSetTableAdapters.BooksBorrowedTableAdapter();
			var dt = ta.GetData();

			try
			{

			}
		}

	}
}
