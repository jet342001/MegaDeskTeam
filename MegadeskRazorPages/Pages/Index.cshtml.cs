using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegadeskRazorPages.Data;
using MegadeskRazorPages.Models;

namespace MegadeskRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MegadeskRazorPages.Data.MegadeskContext _context;

        public IndexModel(MegadeskRazorPages.Data.MegadeskContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }



        [BindProperty(SupportsGet = true)]
        public string NameSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string DateSort { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            var quotes = from quote in _context.Quote select quote;

            switch (sortOrder)
            {
                case "name_desc":
                    quotes = quotes.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    quotes = quotes.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(s => s.Date);
                    break;
                default:
                    quotes = quotes.OrderBy(s => s.CustomerName);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(_ => _.CustomerName.Contains(SearchString));
            }
            Quote = await quotes.ToListAsync();
        }
    }
}
