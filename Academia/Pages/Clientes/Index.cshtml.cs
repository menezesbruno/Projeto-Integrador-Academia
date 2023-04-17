using Academia.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Academia.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly Academia.Data.ApplicationDbContext _context;

        public IndexModel(Academia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get; set; }

        public async Task OnGetAsync()
        {
            Cliente = await _context.Cliente
                .Include(c => c.FormaPagamento)
                .Include(c => c.Personal)
                .ToListAsync();
        }
    }
}
