using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Challenge_3_Resit.Models
{
	public class Class
	{
		public string ClassCode { get; set; }
		public string Name { get; set; }
		public string Building { get; set; }
		public int RoomNo { get; set; }

		public Class(string pClassCode, string pName, string pBuilding, int pRoomNo)
		{
			this.ClassCode = pClassCode;
			this.Name = pName;
			this.Building = pBuilding;
			this.RoomNo = pRoomNo;
		}

		public Class() { }
	}
}