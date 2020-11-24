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
    public class IndexModel : PageModel
    {
        private readonly WebDB_TaxiPool.Data.WebDB_TaxiPoolContext _context;

        public IndexModel(WebDB_TaxiPool.Data.WebDB_TaxiPoolContext context)
        {
            _context = context;
        }

        public IList<Call> Call { get;set; }

        public async Task OnGetAsync()
        {
            Call = await _context.Call
                .Include(c => c.Auto)
                .Include(c => c.Oper)
                .Include(c => c.Rate)
                .Include(c => c.Service).ToListAsync();
        }
    }
}
