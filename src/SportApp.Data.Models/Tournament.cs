using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp.Data.Models
{
    public class Tournament
    {
        public Tournament()
        {
            this.Teams = new HashSet<Team>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Sponsor { get; set; }

        public string Television { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
