using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Core
{
    public class DashboardModel : PageModel
    {
		private readonly StationsScheduler.Data.ApplicationDbContext _context;
		public DashboardModel(StationsScheduler.Data.ApplicationDbContext context) {
			_context = context;
		}


		public IList<Product> Product {
			get; set;
		}
		public IList<Station> Station {
			get; set;
		}

		public async Task OnGetAsync() {
			Station = await _context.Station.ToListAsync();
			Product = await _context.Product.ToListAsync();
		}

	}
}
