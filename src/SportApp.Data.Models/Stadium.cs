using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp.Data.Models
{
    public class Stadium
    {
        public Stadium()
        {
            this.Matches = new HashSet<Match>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Match> Matches { get; set; }

        public int Capacity { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
