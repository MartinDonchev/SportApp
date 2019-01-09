using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Please enter a team name")]
        [RegularExpression(@"([A-Za-z ]+)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a town name")]
        [RegularExpression(@"([A-Za-z ]+)")]
        public string Town { get; set; }

        [UIHint("Date")]
        public DateTime YearOfFoundation { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public Stadium Stadium { get; set; }

        public virtual ICollection<Match> HomeMatches { get; set; }

        public virtual ICollection<Match> AwayMatches { get; set; }
    }
}
