using EunigosApi.Models.CommonModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CustomerVehicleDto : CommonDto
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleManufacturerId { get; set; }
        public string VehicleManufacturerName { get; set; }
        public string VehicleModelId { get; set; }
        public string VehicleModelName { get; set; }
        public string Year { get; set; }
        public string VINNumber { get; set; }
        public string VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public string EngineCode { get; set; }
        public string TenantId { get; set; }
        public string FuelType { get; set; }
    }
}
