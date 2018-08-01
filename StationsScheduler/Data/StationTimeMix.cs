using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StationsScheduler.Data
{
    public class StationTimeMix
    {
		public int Id {
			set;get;
		}
		public StationTimeMix(Station st, double time) {
			Station = st;
			Time = time;
		}
		public Station Station {
			set;get;
		}

		public double Time {
			set;get;
		}
    }
}
