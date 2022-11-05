using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IS7024.Models;

namespace IS7024.Data
{
    public class IS7024Context : DbContext
    {
        public IS7024Context (DbContextOptions<IS7024Context> options)
            : base(options)
        {
        }

        public DbSet<IS7024.Models.Coach> Coach { get; set; }

        public DbSet<IS7024.Models.Player> Player { get; set; }

        public DbSet<IS7024.Models.Team> Team { get; set; }
    }
}
