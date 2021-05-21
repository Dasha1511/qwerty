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
    public class vkModel : PageModel
    {
            private readonly qwerty.Data.qwertyContext _context;

            public vkModel(qwerty.Data.qwertyContext context)
            {
                _context = context;
            }

            public IList<Class> Class { get; set; }
            public vid Vid { get; set; }

            public async Task<IActionResult> OnGetAsync(long? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                Vid = await _context.Vid.FirstOrDefaultAsync(m => m.ID == id);

                if (Vid == null)
                {
                    return NotFound();
                }
                Class = await _context.Class.Where(m => m.vidID == Vid.ID).ToListAsync();
                return Page();
            }
        }
    }

