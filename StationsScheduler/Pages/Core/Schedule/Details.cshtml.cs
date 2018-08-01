using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Core.Schedule
{
    public class DetailsModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;

        public DetailsModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductSchedule ProductSchedule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductSchedule = await _context.ProductSchedule.SingleOrDefaultAsync(m => m.ProductScheduleID == id);

            if (ProductSchedule == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
