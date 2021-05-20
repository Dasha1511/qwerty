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
    public class filtrbukModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public filtrbukModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<students> students { get; set; }
        public Class Class { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            students = await _context.students.Where(m => m.ClassID == Class.ID).ToListAsync();
            return Page();
        }
    }
}

