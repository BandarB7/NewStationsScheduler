using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StationsScheduler.Data
{
	public class ProductSchedule {
		public Product Product {
			set; get;
		}
		public int ProductScheduleID {
			set;get;
			
		}
		public ApplicationUser Owner {
			set;get;
		}
		public  List<StationTimeMix> StationsTime {
			set;get;
		}
	}
}
