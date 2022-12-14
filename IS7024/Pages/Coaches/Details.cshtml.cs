using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IS7024.Data;
using IS7024.Models;

namespace IS7024.Pages.Coaches
{
    public class DetailsModel : PageModel
    {
        private readonly IS7024.Data.IS7024Context _context;

        public DetailsModel(IS7024.Data.IS7024Context context)
        {
            _context = context;
        }

        public Coach Coach { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coach = await _context.Coach
                .Include(c => c.Team).FirstOrDefaultAsync(m => m.CoachId == id);

            if (Coach == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
