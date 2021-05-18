using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Classs
{
    public class IndexModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public IndexModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }
        public IList<vid> Vid { get; set; }
        public IList<sotrudniki> sotrudniki { get; set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
            Vid = await _context.Vid.ToListAsync();
            sotrudniki = await _context.sotrudniki.ToListAsync();
        }
    }
}
