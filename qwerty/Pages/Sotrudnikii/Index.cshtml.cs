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
    public class IndexModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public IndexModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<sotrudniki> sotrudniki { get;set; }
        public IList<Dolznost> Dolznost { get; set; }

        public async Task OnGetAsync()
        {
            sotrudniki = await _context.sotrudniki.ToListAsync();
            Dolznost = await _context.Dolznost.ToListAsync();
        }
    }
}
