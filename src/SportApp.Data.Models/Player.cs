using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp.Data.Models
{
    public class Player
    {
        public int Id { get; set; }

        public virtual Team Team { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }
    }
}
