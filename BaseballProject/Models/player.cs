using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BaseballProject.Models
{
    public class Player
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string TeamName { get; set; }
        public int UniformNumber { get; set; }
        public int PlayerId { get; set; }
    }
}
