﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.Players = new HashSet<Player>();
            this.HomeMatches = new HashSet<Match>();
            this.AwayMatches = new HashSet<Match>();
        }

        public int Id { get; set; }

        public virtual Tournament Tournament { get; set; }

        public string Name { get; set; }

        public string Town { get; set; }

        public DateTime YearOfFoundation { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public Stadium Stadium { get; set; }

        public virtual ICollection<Match> HomeMatches { get; set; }

        public virtual ICollection<Match> AwayMatches { get; set; }
    }
}
