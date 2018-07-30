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
		public DbSet<Product> Products {
			get; set;
		}
		public DbSet<Station> Stations {
			get; set;
		}

	}
}
