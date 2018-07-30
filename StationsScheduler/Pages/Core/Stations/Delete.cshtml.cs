using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Account
{
    public class DeleteModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;

        public DeleteModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Station Station { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Station = await _context.Station.SingleOrDefaultAsync(m => m.StationID == id);

            if (Station == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Station = await _context.Station.FindAsync(id);

            if (Station != null)
            {
                _context.Station.Remove(Station);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("../Dashboard");
        }
    }
}
