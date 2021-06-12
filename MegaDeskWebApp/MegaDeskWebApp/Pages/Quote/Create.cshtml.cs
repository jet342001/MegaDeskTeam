using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using MegaDeskWebApp.Data;
using MegaDeskWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskWebApp.Pages.Quote
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskContext _context;

        public CreateModel(MegaDeskContext context)
        {
            _context = context;
            RushOrderDays = new SelectList(new List<string> { "3", "5", "7", "14" });
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public SelectList RushOrderDays { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DeskQuote.QuoteDate = DateTime.Now;
            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
