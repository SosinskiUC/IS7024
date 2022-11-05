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
    public class IndexModel : PageModel
    {
        private readonly IS7024.Data.IS7024Context _context;

        public IndexModel(IS7024.Data.IS7024Context context)
        {
            _context = context;
        }

        public IList<Coach> Coach { get;set; }

        public async Task OnGetAsync()
        {
            Coach = await _context.Coach
                .Include(c => c.Team).ToListAsync();
        }
    }
}
