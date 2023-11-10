using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Academia.Data;
using Academia.Models;

namespace Academia.Pages.Treinos
{
    public class IndexModel : PageModel
    {
        private readonly Academia.Data.ApplicationDbContext _context;

        public IndexModel(Academia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Treino> Treino { get; set; }

        public async Task OnGetAsync(string searchTerm, string searchCriteria)
        {
            // Consulta inicial para obter todos os clientes
            IQueryable<Treino> treinoQuery = _context.Treino;

            if (!string.IsNullOrEmpty(searchTerm) && !string.IsNullOrEmpty(searchCriteria))
            {
                searchTerm = searchTerm.ToUpper(); 

                if (searchCriteria == "matricula")
                {
                    treinoQuery = treinoQuery.Where(c => c.Matricula.ToUpper().Contains(searchTerm));
                }
                else if (searchCriteria == "nome")
                {
                    treinoQuery = treinoQuery.Where(c => c.Nome.ToUpper().Contains(searchTerm));
                }
                else if (searchCriteria == "sobrenome")
                {
                    treinoQuery = treinoQuery.Where(c => c.Sobrenome.ToUpper().Contains(searchTerm));
                }
            }

            Treino = await treinoQuery.ToListAsync();
        }

        public IActionResult OnGetClearSearch()
        {
            // Redirecione de volta para a página Index sem parâmetros de pesquisa
            return RedirectToPage("Index");
        }
    }
}
