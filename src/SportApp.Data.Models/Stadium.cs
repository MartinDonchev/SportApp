using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Please enter name")]
        [RegularExpression(@"([A-Za-z ]+)")]
        public string Name { get; set; }

        public virtual ICollection<Match> Matches { get; set; }

        [Range(1000,100000)]
        public int Capacity { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
