namespace EunigosApi.Models.Entity.Common
{
    public class Manufacturer : AuditInfo
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ContactInfo { get; set; }
        public string? Website { get; set; }
        public string? LogoUrl { get; set; }
    }
}
