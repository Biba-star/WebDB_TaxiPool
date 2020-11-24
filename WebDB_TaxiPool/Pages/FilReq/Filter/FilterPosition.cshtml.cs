using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_TaxiPool.Models;

namespace WebDB_TaxiPool.Pages.FilReq.Filter
{
    public class FilterPositionModel : PageModel
    {
        private readonly WebDB_TaxiPool.Data.WebDB_TaxiPoolContext _context;
        public FilterPositionModel(WebDB_TaxiPool.Data.WebDB_TaxiPoolContext context)
        {
            _context = context;
        }
        public Position Position { get; set; }
        public IList<Staff> Staff { get; set; }

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
            Staff = await _context.Staff.Include(s => s.Position).Where(m => m.PositionID == Position.ID).ToListAsync();
            return Page();

        }
    }
}
