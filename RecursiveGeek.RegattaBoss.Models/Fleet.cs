using System.Collections.Generic;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class Fleet
    {
        public int FleetId { get; set; }
        public string FleetName { get; set; }
        public List<Boat> Boats { get; set; }
        public List<Series> Series { get; set; }
    }
}
