using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportApp.Data.Models
{
    public class Player
    {
        public int Id { get; set; }

        public virtual Team Team { get; set; }

        public int TeamId { get; set; }

        [Required(ErrorMessage = "Please enter a full name of the player")]
        public string FullName { get; set; }

        [Required]
        [Range(18, 50,
               ErrorMessage = "Please enter age between 18 and 50")]
        public int Age { get; set; }
    }
}
