using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StationsScheduler.Data {
	public class Product {
		public int ProductID {
			get; set;
		}
		public string Name {
			get; set;
		}

		public ApplicationUser Owner {
			set; get;
		}

	}
}