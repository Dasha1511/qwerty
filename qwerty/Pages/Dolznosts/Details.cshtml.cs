using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Dolznosts
{
    public class DetailsModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public DetailsModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
