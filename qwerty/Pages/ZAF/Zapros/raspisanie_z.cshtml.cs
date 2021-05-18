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
    public class raspisanie_zModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public raspisanie_zModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<raspisanie> raspisanie { get; set; }
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

