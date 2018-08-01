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
    public class EditModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;

        public EditModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductScheduleExists(ProductSchedule.ProductScheduleID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("../Dashboard");
        }

        private bool ProductScheduleExists(int id)
        {
            return _context.ProductSchedule.Any(e => e.ProductScheduleID == id);
        }
    }
}
