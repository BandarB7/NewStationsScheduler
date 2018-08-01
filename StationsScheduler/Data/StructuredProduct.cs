using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StationsScheduler.Data
{
    public class StructuredProduct : Product
    {
		IList sequence;

		public StructuredProduct() : base() {
			sequence = new List<KeyValuePair<Station, double>>();
		}

		public void addStep(double time, Station st) {
			sequence.Add(new KeyValuePair<Station, double>(st, time));
		}


	}
}
