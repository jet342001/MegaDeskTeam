﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegadeskRazorPages.Data;
using MegadeskRazorPages.Models;
using MegadeskRazorPages.Business;

namespace MegadeskRazorPages.Pages
{
    public class EditModel : PageModel
    {
        private readonly MegadeskRazorPages.Data.MegadeskContext _context;

        public EditModel(MegadeskRazorPages.Data.MegadeskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quote.FirstOrDefaultAsync(m => m.ID == id);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Quote.Date = DateTime.Now;
            Quote.Price = Calculator.GetCalculatedPrice(Quote);
            Quote.Size = Quote.DeskDepth * Quote.DeskWidth;

            _context.Attach(Quote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(Quote.ID))
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

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.ID == id);
        }
    }
}
