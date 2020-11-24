using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_TaxiPool.Data;
using WebDB_TaxiPool.Models;

namespace WebDB_TaxiPool.Pages.Positions
{
    public class DeleteModel : PageModel
    {
        private readonly WebDB_TaxiPool.Data.WebDB_TaxiPoolContext _context;

        public DeleteModel(WebDB_TaxiPool.Data.WebDB_TaxiPoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Position Position { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FirstOrDefaultAsync(m => m.ID == id);

            if (Position == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FindAsync(id);

            if (Position != null)
            {
                _context.Position.Remove(Position);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
