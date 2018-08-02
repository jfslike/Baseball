using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballProject.Models
{
    public class Stadium
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Capacity { get; set; }
        public int YearBuilt { get; set; }

    }
}
