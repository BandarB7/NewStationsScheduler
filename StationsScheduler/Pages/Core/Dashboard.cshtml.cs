using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;


namespace StationsScheduler.Pages.Core
{
    public class DashboardModel : PageModel
    {
		private readonly UserManager<ApplicationUser> _userManager;

		private readonly StationsScheduler.Data.ApplicationDbContext _context;
		public DashboardModel(StationsScheduler.Data.ApplicationDbContext context, UserManager<ApplicationUser> userManager) {
			_context = context;
			_userManager = userManager;

		}


		public IList<Product> Product {
			get; set;
		}
		public IList<Station> Station {
			get; set;
		}
		public IList<ProductSchedule> ProductSchedule {
			get; set;
		}



		public async Task OnGetAsync() {
			Station = await _context.Station.ToListAsync();
			Product = await _context.Product.ToListAsync();
			ProductSchedule = await _context.ProductSchedule.ToListAsync();
		}

	}
}
