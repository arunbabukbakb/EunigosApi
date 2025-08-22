using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.JobCardManagement;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.EstimateManagement
{
    public class Estimate : AuditInfo
    {

		public string EstimateNumber { get; set; }
		public string TicketId { get; set; }
		public EstimateStatus Status { get; set; }
		public DateTime EntryDate { get; set; }
		public DateTime? ExpectedCompletionDate { get; set; }
        public bool IsLumpsum { get; set; } = false;
        public decimal? LumpsumAmount { get; set; }
        public bool IsDiscount { get; set; } = false;
        public decimal? DiscountAmount { get; set; }
        public decimal? Kilometers { get; set; }
        public string KilometersImagePath { get; set; }
        public int DeliveryDays { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string? CustomerComments { get; set; }
        public string JobDescription { get; set; }


        public bool IsSupplementary { get; set; } = false;
		public string? ParentEstimateId { get; set; }	
		public decimal NetAmount { get; set; }
		public bool IsClone { get; set; } = false;
		public string? ClonedFromId { get; set; }
		public string CustomerAccept { get; set; }
		public string CustomerNotes { get; set; }
		public string CustomerSignature { get; set; }
		public DateTime? VehicleDropDateTime { get; set; }
		public decimal? VehicleDropOdometerReading { get; set; }
		public string VehicleDropOdometerImage { get; set; }
		public bool IsCopy { get; set; } = false;
		public string? CopyFromId { get; set; }
        public bool IsCopyDone { get; set; }
        public DateTime? CopyCreateDateTime { get; set; }		
		public bool IsSettlement { get; set; } = false;
		public decimal? SettlementAmount {  get; set; }
		public decimal? SettlementDiscount {  get; set; }
		public string PaymentMethod {  get; set; }	
		
		
		public ICollection<Estimate> ClonedEstimates { get; set; }
		public ICollection<Estimate> SupplementaryEstimates { get; set; }
		public ICollection<EstimateItem> EstimateItems { get; set; }
		public ICollection<EstimateDocument> EstimateDocuments { get; set; }

        // Navigation Properties
        public EstimateApproval EstimateApproval { get; set; }
        public Ticket Ticket { get; set; }
		public JobCard JobCard { get; set; }

		public Estimate ParentEstimate_Nav { get; set; }
        public Estimate ClonedFrom_Nav { get; set; }

        //public Coupon Coupon { get; set; }
        public Tenant Tenant_Nav { get; set; }
       
    }
}
