namespace StationsScheduler.Data {
	public class Station {
		public int StationID {
			get; set;
		}
		public string Name {
			get; set;
		}
		public double Capacity {
			get;set;
		}

		public ApplicationUser Owner {
			set; get;
		}

		public string toString() {
			return Name;
		}
	}
}