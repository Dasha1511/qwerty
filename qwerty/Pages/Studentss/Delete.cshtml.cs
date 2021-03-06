using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Studentss
{
    public class DeleteModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public DeleteModel(qwerty.Data.qwertyContext context)
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            students = await _context.students.FindAsync(id);

            if (students != null)
            {
                _context.students.Remove(students);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
