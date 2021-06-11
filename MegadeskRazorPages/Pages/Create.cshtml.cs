using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegadeskRazorPages.Data;
using MegadeskRazorPages.Models;
using MegadeskRazorPages.Business;

namespace MegadeskRazorPages.Pages
{
    public class CreateModel : PageModel
    {
        private readonly MegadeskRazorPages.Data.MegadeskContext _context;

        public CreateModel(MegadeskRazorPages.Data.MegadeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Quote Quote { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Quote.Date = DateTime.Now;
            Quote.Price = Calculator.GetCalculatedPrice(Quote);
            Quote.Size = Quote.DeskDepth * Quote.DeskWidth;

            _context.Quote.Add(Quote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
