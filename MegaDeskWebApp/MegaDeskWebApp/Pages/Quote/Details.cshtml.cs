using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MegaDeskWebApp.Pages.Quote
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskWebApp.Data.MegaDeskContext _context;

        public DetailsModel(MegaDeskWebApp.Data.MegaDeskContext context)
        {
            _context = context;
        }

        public Models.DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.Id == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
