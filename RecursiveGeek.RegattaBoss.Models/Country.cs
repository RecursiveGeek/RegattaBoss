using System.Collections.Generic;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<Organization> Organizations { get; set; }
    }
}
