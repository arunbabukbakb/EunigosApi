namespace EunigosApi.Models.Entity.Common
{
    public class Unit : AuditInfo
    {
        public string Name { get; set; }
        public string? Abbreviation { get; set; }
        public string? Description { get; set; }
        public string? BaseUnitId { get; set; }
        public Unit? BaseUnit { get; set; }
        public decimal? ConversionFactor { get; set; }
    }
}
