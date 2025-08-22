using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TicketDto : CommonDto
    {
        public string Id { get; set; }
        public DateTime DropOffDate { get; set; }
        public string TicketNumber { get; set; }
        public string RepairTypeId { get; set; }
        public string RepairTypeName { get; set; }
        public string JobTypeId { get; set; }
        public string JobTypeName { get; set; }
        public string AdvisorId { get; set; }        
        public string AdvisorName { get; set; }        
        public string CustomerComments { get; set; }
        public DateTime ExpectedPickupTime { get; set; }
        //Customer data
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        //Owner data
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        //Corporate data
        public string CorporateId { get; set; }
        public string CorporateName { get; set; }
        //ContactPerson data
        public string ContactPersonId { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }

        public string JobCardNumber { get; set; }
        public string  ServiceDetails { get; set; }
        public string TenantId { get; set; }
        public int TicketId {  get; set; }    
        public TicketStatus Status { get; set; }
        public string StatusName { get; set; }

        //Vehicle
        public string CustomerVehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleManufacturerId { get; set; }
        public string VehicleManufaturerName { get; set; }
        
        public string VehicleModelId { get; set; }
        public string VehicleModelName { get; set; }
        public string Year { get; set; }
        public string VINNumber { get; set; }
        public string VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
        public string EngineCode { get; set; }
        public string FuelType { get; set; }
        public VehicleInspectionDto Inspections { get; set; } 
    }
}
