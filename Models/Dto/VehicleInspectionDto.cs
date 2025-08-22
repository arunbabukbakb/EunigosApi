using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.VehicleManagement;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class VehicleInspectionDto : CommonDto
    {
        public string Id { get; set; }
        public string TicketId { get; set; }
        public double OdometerReading { get; set; }
        public string MeterReadingType { get; set; }
        public string InspectionComments { get; set; }
        public List<string> InventoryItems { get; set; } = new();
        public string InventoryNotes { get; set; }
        public string CustomerSignature { get; set; }
        public double FuelLevel { get; set; }
        public string TenantId { get; set; }
        public string FuelTypeId { get; set; }
        public string TechnicianId { get; set; }
        public List<InspectionMediaDto> InspectionMedias { get; set; }
    }
}
