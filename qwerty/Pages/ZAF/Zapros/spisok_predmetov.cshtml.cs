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
    public class spisok_predmetovModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public spisok_predmetovModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }

        public IList<predmet> predmet { get; set; }
        public IList<sotrudniki> sotrudniki { get; set; }

        public async Task OnGetAsync()
        {
            predmet = await _context.predmet.ToListAsync();
            sotrudniki = await _context.sotrudniki.ToListAsync();
        }
    }
}