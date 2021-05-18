using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using school.models;

namespace qwerty.Pages.ZAF.Zapros
{
    public class spisok_uchenikovModel : PageModel
    {
            private readonly qwerty.Data.qwertyContext _context;

            public spisok_uchenikovModel(qwerty.Data.qwertyContext context)
            {
                _context = context;
            }

            public IList<students> students { get; set; }
            public IList<Class> Class { get; set; }

            public async Task OnGetAsync()
            {
                students = await _context.students.ToListAsync();
                Class = await _context.Class.ToListAsync();
            }
        }
    }


