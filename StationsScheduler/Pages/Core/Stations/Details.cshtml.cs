using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Core.Stations
{
    public class DetailsModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;

        public DetailsModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
