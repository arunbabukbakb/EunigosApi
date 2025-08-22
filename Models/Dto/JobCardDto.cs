using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class JobCardDto : CommonDto
    {
		public string Id { get; set; }
		public string JobcardNumber { get; set; }
		public string TicketId { get; set; }
		public string TicketNumber { get; set; }
		public DateTime ExpectedDeliveryDatetime { get; set; }
		public string EstimateId { get; set; }

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
		public string Odometer { get; set; }
		public string OdometerImagePath { get; set; }
		public DateTime? VehicleDropDateTime { get; set; }
		public string VehicleDropOdometerImage { get; set; }
		public string VehicleDropOdometerReading { get; set; }
		public string CustomerComments { get; set; }
		public string JobDescription { get; set; }
		public decimal GrossAmount { get; set; }
		public decimal TaxAmount { get; set; }
		public decimal NetAmount { get; set; }
		public bool IsLumpsum { get; set; }
		public decimal LumpsumAmount { get; set; }
		public bool IsDiscount { get; set; }
		public decimal DiscountAmount { get; set; }
		// Child Collections
		public List<EstimateItemDto> EstimateItems { get; set; }
		public List<EstimateDocumentDto> EstimateDocuments { get; set; }
		public List<JobCardItemDto> Items { get; set; }
		public List<JobCardDocumentDto> Documents { get; set; }
		public InsuranceDetailDto? Insurance { get; set; }

		public string AssignedToId { get; set; }
		public string LocationId { get; set; }
		public string RepairKitId { get; set; }
		public string? AssignedTo { get; set; }
		public JobCardStatus Status { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public string? Notes { get; set; }
		//public List<string> Items { get; set; }
		public string TenantId { get; set; }

	}
}
