using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Core.Schedule
{
    public class CreateModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;
		ProductsController productsController;
        public CreateModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
			productsController = new ProductsController(_context);

		}

        public async Task<IActionResult> OnGetAsync()
        {
			Products = await _context.Product.ToListAsync();
			Stations = await _context.Station.ToListAsync();
			return Page();
        }

		[BindProperty]
		public ProductSchedule Schedule {
			get; set;
		}
		[BindProperty]
		public List<Product> Products {
			get; set;
		}
		[BindProperty]
		public List<Station> Stations {
			get;set;
		}




		public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
			
			_context.ProductSchedule.Add(Schedule);
			await _context.SaveChangesAsync();
            return RedirectToPage("../Dashboard");
        }
    }
}