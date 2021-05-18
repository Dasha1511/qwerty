using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using school.models;

namespace qwerty.Pages.ZAF.Filtr
{
    public class sotrudniki_odModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public sotrudniki_odModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<sotrudniki> sotrudniki { get; set; }
        public Dolznost Dolznost { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dolznost = await _context.Dolznost.FirstOrDefaultAsync(m => m.ID == id);

            if (Dolznost == null)
            {
                return NotFound();
            }
            sotrudniki = await _context.sotrudniki.Where(m => m.DolznostID == Dolznost.ID).ToListAsync();
            return Page();
        }
    }
}
