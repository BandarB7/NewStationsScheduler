using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StationsScheduler.Data
{
    public class StructuredStation: Station
    {
		Product[] productionLine;
		public StructuredStation() {
			productionLine = new Product[(int)Capacity];
		}

		//revise to StructuredProduct
		public void addProduct(Product p) {
			productionLine.Append(p);
		}
	}
}
