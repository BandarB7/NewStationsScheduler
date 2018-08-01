using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace StationsScheduler.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
		public ICollection<Product> Products {
			get; set;
		}
		public ICollection<Station> Stations {
			get; set;
		}

		public ICollection<ProductSchedule> ProductSchedules {
			get;set;
		}
	}
}
