using Academia.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task OnGetAsync(string searchTerm, string searchCriteria)
        {
            // Consulta inicial para obter todos os clientes
            IQueryable<Cliente> clienteQuery = _context.Cliente
                    .Include(c => c.FormaPagamento)
                    .Include(c => c.Personal);


            if (!string.IsNullOrEmpty(searchTerm) && !string.IsNullOrEmpty(searchCriteria))
            {
                searchTerm = searchTerm.ToUpper(); // Converter o termo de pesquisa para maiúsculas

                // Aplicar filtro com base no critério de pesquisa escolhido
                if (searchCriteria == "matricula")
                {
                    clienteQuery = clienteQuery.Where(c => c.Matricula.ToUpper().Contains(searchTerm));
                }
                else if (searchCriteria == "nome")
                {
                    clienteQuery = clienteQuery.Where(c => c.Nome.ToUpper().Contains(searchTerm));
                }
                else if (searchCriteria == "sobrenome")
                {
                    clienteQuery = clienteQuery.Where(c => c.Sobrenome.ToUpper().Contains(searchTerm));
                }
            }

            Cliente = await clienteQuery.ToListAsync();
        }

        public IActionResult OnGetClearSearch()
        {
            // Redirecione de volta para a página Index sem parâmetros de pesquisa
            return RedirectToPage("Index");
        }
    }
}
