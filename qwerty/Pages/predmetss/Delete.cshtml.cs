using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.predmetss
{
    public class DeleteModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public DeleteModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public predmet predmet { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            predmet = await _context.predmet.FirstOrDefaultAsync(m => m.ID == id);

            if (predmet == null)
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

            predmet = await _context.predmet.FindAsync(id);

            if (predmet != null)
            {
                _context.predmet.Remove(predmet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
