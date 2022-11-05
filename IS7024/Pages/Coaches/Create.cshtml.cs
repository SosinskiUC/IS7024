using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IS7024.Data;
using IS7024.Models;

namespace IS7024.Pages.Coaches
{
    public class CreateModel : PageModel
    {
        private readonly IS7024.Data.IS7024Context _context;

        public CreateModel(IS7024.Data.IS7024Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TeamId"] = new SelectList(_context.Set<Team>(), "TeamId", "TeamId");
            return Page();
        }

        [BindProperty]
        public Coach Coach { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Coach.Add(Coach);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
