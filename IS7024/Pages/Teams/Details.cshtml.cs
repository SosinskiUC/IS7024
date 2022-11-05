using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IS7024.Data;
using IS7024.Models;

namespace IS7024.Pages.Teams
{
    public class DetailsModel : PageModel
    {
        private readonly IS7024.Data.IS7024Context _context;

        public DetailsModel(IS7024.Data.IS7024Context context)
        {
            _context = context;
        }

        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Team = await _context.Team.FirstOrDefaultAsync(m => m.TeamId == id);

            if (Team == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
