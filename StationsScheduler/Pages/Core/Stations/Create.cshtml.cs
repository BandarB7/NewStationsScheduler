﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StationsScheduler.Data;

namespace StationsScheduler.Pages.Core.Stations
{
    public class CreateModel : PageModel
    {
        private readonly StationsScheduler.Data.ApplicationDbContext _context;

        public CreateModel(StationsScheduler.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Station Station { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Station.Add(Station);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Dashboard");
        }
    }
}