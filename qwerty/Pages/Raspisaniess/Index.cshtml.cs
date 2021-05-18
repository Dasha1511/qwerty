using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using qwerty.Data;
using school.models;

namespace qwerty.Pages.Raspisaniess
{
    public class IndexModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public IndexModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<raspisanie> raspisanie { get;set; }
        public IList<predmet> predmet { get; set; }
        public IList<Class> Class { get; set; }

        public async Task OnGetAsync()
        {
            raspisanie = await _context.raspisanie.ToListAsync();
            predmet = await _context.predmet.ToListAsync();
            Class = await _context.Class.ToListAsync();
        }
    }
}
