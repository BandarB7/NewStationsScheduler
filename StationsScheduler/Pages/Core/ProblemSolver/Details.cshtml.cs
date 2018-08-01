using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Core.ProblemSolver
{
    public class DetailsModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;

        public DetailsModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Problem Problem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Problem = await _context.Problem.SingleOrDefaultAsync(m => m.Id == id);

            if (Problem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
