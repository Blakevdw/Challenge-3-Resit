using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Challenge_3_Resit.Models
{
	public class Room
	{
		public string Building { get; set; }
		public int RoomNo { get; set; }
		public int Capacity { get; set; }

		public Room(string pBuilding, int pRoomNo, int pCapacity)
		{
			this.Building = pBuilding;
			this.RoomNo = pRoomNo;
			this.Capacity = pCapacity;
		}


		public Room() { }
	}
}