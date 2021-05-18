﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Studentss
{
    public class EditModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public EditModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public students students { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            students = await _context.students.FirstOrDefaultAsync(m => m.ID == id);

            if (students == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(students).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!studentsExists(students.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool studentsExists(long id)
        {
            return _context.students.Any(e => e.ID == id);
        }
    }
}
