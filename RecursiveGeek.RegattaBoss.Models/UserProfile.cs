using System.Collections.Generic;

namespace RecursiveGeek.RegattaBoss.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string Username { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
        public List<Boat> Boats { get; set; } // The boats they are affiliated
    }
}
