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
    public class DetailsModel : PageModel
    {
        private readonly MegadeskRazorPages.Data.MegadeskContext _context;

        public DetailsModel(MegadeskRazorPages.Data.MegadeskContext context)
        {
            _context = context;
        }

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
    }
}
