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
    public class IndexModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public IndexModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<predmet> predmet { get;set; }
        public IList<sotrudniki> sotrudniki { get; set; }

        public async Task OnGetAsync()
        {
            predmet = await _context.predmet.ToListAsync();
            sotrudniki = await _context.sotrudniki.ToListAsync();
        }
    }
}
