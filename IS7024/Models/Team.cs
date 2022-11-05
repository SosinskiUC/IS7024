using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS7024.Models
{
    public class Team
    {

        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public List<Coach> Coaches { get; set; }

        public List<Player> Players { get; set; }
    }
}
