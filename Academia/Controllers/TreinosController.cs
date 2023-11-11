using Academia.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academia.Controllers
{
    public class TreinosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TreinosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Outras ações do controlador

        public async Task<IActionResult> BuscarMatricula(string matricula)
        {
            var cliente = await _context.Cliente.FirstOrDefaultAsync(c => c.Matricula == matricula);

            if (cliente != null)
            {
                return Json(new { Nome = cliente.Nome, Sobrenome = cliente.Sobrenome });
            }
            else
            {
            return Json(new { mensagem = "Mátricula não encontrada" });
            }
        }
    }
}

