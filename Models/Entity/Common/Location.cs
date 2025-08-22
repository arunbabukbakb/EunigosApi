namespace EunigosApi.Models.Entity.Common
{
    public class Location : AuditInfo
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }
        public decimal? Altitude { get; set; }
        public decimal? Accuracy { get; set; }

    }
}
