using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportApp.Data.Models
{
    public class Match
    {
        public int Id { get; set; }

        public int HomeTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }

        public int AwayTeamId { get; set; }

        public virtual Team AwayTeam { get; set; }

        public DateTime DateOfMatch { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [RegularExpression(@"([A-Za-z ]+)")]
        public string Referee { get; set; }
    }
}
