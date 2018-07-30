using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StationsScheduler.Data
{
    public class Product
    {
		public int ProductID {
			get; set;
		}
		public string Name {
			get; set;
		}
		public double time {
			get; set;
		}
		
		public Queue<Station> Stations {
			get; set;
		}
	}
}
