using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Please enter name")]
        [RegularExpression(@"([A-Za-z ]+)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [RegularExpression(@"([A-Za-z ]+)")]
        public string Sponsor { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [RegularExpression(@"([A-Za-z ]+)")]
        public string Television { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
