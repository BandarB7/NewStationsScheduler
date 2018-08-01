using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StationsScheduler.Data
{
    public class ProductSchedule
    {

		public int ProductScheduleID {
			set; get;
		}
		public ApplicationUser Owner {
			set;get;
		}
		/*
		public Product Product {
			set;get;
		}
		public Station Station {
			set;get;
		}
		*/
		public int ProductID {
			set;get;
		}
		public int StationID {
			set;get;
		}
		public int Time {
			set;get;
		}
	}
}
