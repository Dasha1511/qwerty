using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Vids
{
    public class DetailsModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public DetailsModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public vid vid { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            vid = await _context.Vid.FirstOrDefaultAsync(m => m.ID == id);

            if (vid == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
