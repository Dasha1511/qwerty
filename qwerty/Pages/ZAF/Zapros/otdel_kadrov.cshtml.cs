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
    public class otdel_kadrovModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public otdel_kadrovModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<sotrudniki> sotrudniki { get; set; }
        public IList<Dolznost> Dolznost { get; set; }

        public async Task OnGetAsync()
        {
            sotrudniki = await _context.sotrudniki.ToListAsync();
            Dolznost = await _context.Dolznost.ToListAsync();
        }
    }
}
