using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace qwerty.Pages.ZAF
{
    public class IndexModel : PageModel
    {
        private readonly qwerty.Data.qwertyContext _context;

        public IndexModel(qwerty.Data.qwertyContext context)
        {
            _context = context;
        }
        public List<SelectListItem> otdel { get; set; }
        public List<SelectListItem> god { get; set; }
        public IActionResult OnGet()
        {
            otdel = _context.Dolznost.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Naimenovanie_dolznosti
                }).ToList();

            god = _context.Class.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Bukva
                }).ToList();
            return Page();
        }

    }
}
