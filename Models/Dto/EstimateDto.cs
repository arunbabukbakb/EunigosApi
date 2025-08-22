using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class EstimateDto : CommonDto
    {
        public string Id { get; set; }
        public string EstimateNumber { get; set; }
        public string TicketId { get; set; }
        public string TicketNumber { get; set; }
        public EstimateStatus Status { get; set; }
        public int DeliveryDays { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExpectedCompletionDate { get; set; }
        public decimal GrossAmount { get; set; }
        public bool IsDiscount { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsLumpsum { get; set; }
        public decimal LumpsumAmount { get; set; }            
        public bool IsSupplementary { get; set; }
        public string? ParentEstimateId { get; set; }         
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string? CustomerComments { get; set; }       
        public string? JobDescription { get; set; }
		public decimal Kilometers { get; set; }
		public string? KilometersImagepath { get; set; }
        public bool IsClone { get; set; }
		public string? ClonedFromId { get; set; }
        public bool IsCopy {  get; set; }
        public string? CopyFromId {  get; set; }
        public bool IsCopyDone { get; set; }
        public DateTime DropOffDate { get; set; }
        public DateTime ExpectedPickupTime { get; set; }


        // Customer
        public string RepairtypeId { get; set; }
        public string RepairtypeName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }// need mapping
        public string OwnerId { get; set; }// need mapping
        public string OwnerName { get; set; }// need mapping
        public string CorporateId { get; set; }// need mapping
        public string CorporateName { get; set; }// need mapping


        // Contact Person
        public string ContactPersonId { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactNumber { get; set; }

        // Customer Vehicle
        public string CustomerVehicleId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleNumber { get; set; }
        public string VINNumber { get; set; }
        public string ManufactureId { get; set; }
        public string ModelId { get; set; }


        // Advisor
        public string AdvisorId { get; set; }
        public string AdvisorName { get; set; }

        // Job Type
        public string JobtypeId { get; set; }
        public string JobtypeName { get; set; }

        public string TenantId { get; set; }

        public List<EstimateItemDto>? Items { get; set; } 
        public List<EstimateDocumentDto>? Documents { get; set; } 
        public InsuranceDetailDto? Insurance { get; set; } 
        public EstimateApprovalDto? ApprovalDetails { get; set; }
        [JsonIgnore]
        public TicketDto? Ticket { get; set; }
    }
}
