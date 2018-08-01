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
    public class IndexModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;

        public IndexModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Problem> Problem { get;set; }

        public async Task OnGetAsync()
        {
            Problem = await _context.Problem.ToListAsync();
        }
    }
}
