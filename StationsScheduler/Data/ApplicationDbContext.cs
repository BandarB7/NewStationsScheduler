using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
			
        }

        public DbSet<StationsScheduler.Data.Product> Product { get; set; }

        public DbSet<StationsScheduler.Data.Station> Station { get; set; }

        public DbSet<StationsScheduler.Data.ProductSchedule> ProductSchedule { get; set; }

        public DbSet<StationsScheduler.Data.Problem> Problem { get; set; }



	}
}
