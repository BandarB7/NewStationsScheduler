using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;
using StationsScheduler.Data.Migrations;

namespace StationsScheduler.Pages.Core.Products
{
	public class CreateModel : PageModel {
		private readonly StationsScheduler.Data.ApplicationDbContext _context;

		public CreateModel(StationsScheduler.Data.ApplicationDbContext context) {
			_context = context;
		}


		public async Task OnGetAsync() {

		}
			



		[BindProperty]
		public Product Product { get; set; }



	public async Task<IActionResult> OnPostAsync()
        {

			if (!ModelState.IsValid)
            {
                return Page();
            }

			_context.Product.Add(Product);
			await _context.SaveChangesAsync();
			return RedirectToPage("../Dashboard");

		}


	}
}