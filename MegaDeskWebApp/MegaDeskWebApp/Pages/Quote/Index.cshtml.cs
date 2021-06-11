using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebApp.Data;
using MegaDeskWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MegaDeskWebApp.Pages.Quote
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskContext _context;

        public IndexModel(MegaDeskContext context)
        {
            _context = context;
        }

        public string DateSort { get; set; }
        public string NameSort { get; set; }

        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {

            CurrentFilter = searchString;

            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            IQueryable<DeskQuote> quoteQuery = from s in _context.DeskQuote
                                               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                quoteQuery = quoteQuery.Where(s => s.FullName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    quoteQuery = quoteQuery.OrderByDescending(s => s.FullName);
                    break;
                case "Date":
                    quoteQuery = quoteQuery.OrderBy(s => s.QuoteDate);
                    break;
                case "date_desc":
                    quoteQuery = quoteQuery.OrderByDescending(s => s.QuoteDate);
                    break;
                default:
                    quoteQuery = quoteQuery.OrderBy(s => s.TotalPrice);
                    break;
            }

            // DeskQuote = await quoteQuery.AsNoTracking().ToListAsync();
            DeskQuote = await _context.DeskQuote.AsNoTracking().ToListAsync();
        }
    }
}
