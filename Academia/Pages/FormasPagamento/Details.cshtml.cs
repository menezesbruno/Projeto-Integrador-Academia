using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Academia.Data;
using Academia.Models;

namespace Academia.Pages.FormasPagamento
{
    public class DetailsModel : PageModel
    {
        private readonly Academia.Data.ApplicationDbContext _context;

        public DetailsModel(Academia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public FormaPagamento FormaPagamento { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FormaPagamento = await _context.FormaPagamento.FirstOrDefaultAsync(m => m.Id == id);

            if (FormaPagamento == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
