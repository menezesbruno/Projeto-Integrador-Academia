using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Academia.Data;
using Academia.Models;

namespace Academia.Pages.Personais
{
    public class CreateModel : PageModel
    {
        private readonly Academia.Data.ApplicationDbContext _context;

        public CreateModel(Academia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Personal Personal { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Personal.Add(Personal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
