using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Challenge_3_Resit.Models
{
	public class Computer
	{
		public int Number { get; set; }
		public int AssembledYear { get; set; }
		public string Building { get; set; }
		public int RoomNo { get; set; }

		public Computer(int pNumber, int pAssembledYear, string pBuilding, int pRoomNo)
		{
			this.Number = pNumber;
			this.AssembledYear = pAssembledYear;
			this.Building = pBuilding;
			this.RoomNo = pRoomNo;
		}

		public Computer() { }

	}
}