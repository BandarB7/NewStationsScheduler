using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StationsScheduler.Data
{
    public class Problem
    {
		private List<Station> stations;
		private List<Product> products;

		public int Id {
			set;get;
		}

		public List<Product> Products {
			get;set;
		}
		public List<Station> Stations {
			get;set;
		}
	}
}
