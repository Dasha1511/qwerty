﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Sotrudnikii
{
    public class CreateModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public CreateModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public sotrudniki sotrudniki { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.sotrudniki.Add(sotrudniki);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
