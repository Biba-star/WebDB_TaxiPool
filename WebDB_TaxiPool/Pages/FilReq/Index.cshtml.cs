using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebDB_TaxiPool.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_TaxiPool.Data.WebDB_TaxiPoolContext _context;
        public IndexModel(WebDB_TaxiPool.Data.WebDB_TaxiPoolContext context)
        {

            _context = context;
        }
        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelBrand { get; set; }
        public List<SelectListItem> SelRate { get; set; }

        public void OnGet()
        {
            SelPosition = _context.Position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();
            SelBrand = _context.Brand.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();
            SelRate = _context.Rate.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.ID.ToString(),
                                      Text = p.Name
                                  }).ToList();
        }
    }
}
