namespace RecursiveGeek.RegattaBoss.Models
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string Website { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
    }
}
