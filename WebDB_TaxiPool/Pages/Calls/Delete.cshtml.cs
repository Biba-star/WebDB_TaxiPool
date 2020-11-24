using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_TaxiPool.Data;
using WebDB_TaxiPool.Models;

namespace WebDB_TaxiPool.Pages.Calls
{
    public class DeleteModel : PageModel
    {
        private readonly WebDB_TaxiPool.Data.WebDB_TaxiPoolContext _context;

        public DeleteModel(WebDB_TaxiPool.Data.WebDB_TaxiPoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Call Call { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Call = await _context.Call
                .Include(c => c.Auto)
                .Include(c => c.Oper)
                .Include(c => c.Rate)
                .Include(c => c.Service).FirstOrDefaultAsync(m => m.ID == id);

            if (Call == null)
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

            Call = await _context.Call.FindAsync(id);

            if (Call != null)
            {
                _context.Call.Remove(Call);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
