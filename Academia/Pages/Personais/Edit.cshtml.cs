using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Academia.Data;
using Academia.Models;

namespace Academia.Pages.Personais
{
    public class EditModel : PageModel
    {
        private readonly Academia.Data.ApplicationDbContext _context;

        public EditModel(Academia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Personal Personal { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Personal = await _context.Personal.FirstOrDefaultAsync(m => m.Id == id);

            if (Personal == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Personal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalExists(Personal.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PersonalExists(Guid id)
        {
            return _context.Personal.Any(e => e.Id == id);
        }
    }
}
