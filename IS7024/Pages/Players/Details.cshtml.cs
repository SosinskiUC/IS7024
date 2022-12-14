using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IS7024.Data;
using IS7024.Models;

namespace IS7024.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly IS7024.Data.IS7024Context _context;

        public DetailsModel(IS7024.Data.IS7024Context context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Player
                .Include(p => p.Team).FirstOrDefaultAsync(m => m.PlayerId == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
