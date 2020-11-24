using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDB_TaxiPool.Data;
using WebDB_TaxiPool.Models;

namespace WebDB_TaxiPool.Pages.Calls
{
    public class EditModel : PageModel
    {
        private readonly WebDB_TaxiPool.Data.WebDB_TaxiPoolContext _context;

        public EditModel(WebDB_TaxiPool.Data.WebDB_TaxiPoolContext context)
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
           ViewData["AutoID"] = new SelectList(_context.Auto, "ID", "ID");
           ViewData["OperID"] = new SelectList(_context.Set<Staff>(), "ID", "ID");
           ViewData["RateID"] = new SelectList(_context.Set<Rate>(), "ID", "ID");
           ViewData["ServiceID"] = new SelectList(_context.Set<Service>(), "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Call).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CallExists(Call.ID))
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

        private bool CallExists(long id)
        {
            return _context.Call.Any(e => e.ID == id);
        }
    }
}
