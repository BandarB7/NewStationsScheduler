using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;
using StationsScheduler.Pages.Core.Schedule;
using StationsScheduler.Pages.Core.Stations;

namespace StationsScheduler.Pages.Core.ProblemSolver
{
	public class CreateModel : PageModel {
		private readonly StationsScheduler.Data.ApplicationDbContext _context;
		private ProblemsController problemsController;
		private ProductsController productsController;
		private SchedulesController schedulesController;
		private StationsController stationsController;

		public CreateModel(StationsScheduler.Data.ApplicationDbContext context) {
			_context = context;
			Products = new List<Product>();
			Stations = new List<Station>();
			schedulesController = new SchedulesController(context);
		}

		public async Task<IActionResult> OnGetAsync() {
			Product product;
			Schedules = await _context.ProductSchedule.ToListAsync();
			foreach (var entry in Schedules) {
				product = entry.Product;
			}
			return Page();
		}

		[BindProperty]
		public Problem Problem { get; set; }

		public List<ProductSchedule> Schedules{
			set;get;
			}

		public List<Product> Products {
			set;get;
		}

		public List<Station> Stations {
			set;get;
		}

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Problem.Add(Problem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}