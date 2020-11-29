using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Assignment_4.Models
{
    public class Details
    {
        public string? Park { get; set; }
        public string? States { get; set; }
        public List<ParkInfo>? data { get; set; }
    }

    public class ParkInfo
    {
        public string? TourInfo { get; set; }
        public string? CampInfo { get; set; }
    }
}
