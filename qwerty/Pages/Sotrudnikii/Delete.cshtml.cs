using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Sotrudnikii
{
    public class DeleteModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public DeleteModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public sotrudniki sotrudniki { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            sotrudniki = await _context.sotrudniki.FirstOrDefaultAsync(m => m.ID == id);

            if (sotrudniki == null)
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

            sotrudniki = await _context.sotrudniki.FindAsync(id);

            if (sotrudniki != null)
            {
                _context.sotrudniki.Remove(sotrudniki);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
