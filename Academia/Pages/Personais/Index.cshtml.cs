using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Academia.Data;
using Academia.Models;

namespace Academia.Pages.Personais
{
    public class IndexModel : PageModel
    {
        private readonly Academia.Data.ApplicationDbContext _context;

        public IndexModel(Academia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Personal> Personal { get;set; }

        public async Task OnGetAsync()
        {
            Personal = await _context.Personal
                .ToListAsync();
        }
    }
}
