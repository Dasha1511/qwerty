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
    public class DetailsModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public DetailsModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

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
    }
}
