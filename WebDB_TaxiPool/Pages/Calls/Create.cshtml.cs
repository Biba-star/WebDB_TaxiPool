using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebDB_TaxiPool.Data;
using WebDB_TaxiPool.Models;

namespace WebDB_TaxiPool.Pages.Calls
{
    public class CreateModel : PageModel
    {
        private readonly WebDB_TaxiPool.Data.WebDB_TaxiPoolContext _context;

        public CreateModel(WebDB_TaxiPool.Data.WebDB_TaxiPoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AutoID"] = new SelectList(_context.Auto, "ID", "ID");
        ViewData["OperID"] = new SelectList(_context.Set<Staff>(), "ID", "ID");
        ViewData["RateID"] = new SelectList(_context.Set<Rate>(), "ID", "ID");
        ViewData["ServiceID"] = new SelectList(_context.Set<Service>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Call Call { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Call.Add(Call);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
