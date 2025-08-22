namespace EunigosApi.Models.Entity.Common
{
    public class State : AuditInfo
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string CountryId { get; set; }

        // One-to-Many Relationship with City (State has many Cities)
        public ICollection<City> Cities { get; set; }
        public Country Country { get; set; }
    }
}
