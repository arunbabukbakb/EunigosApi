using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.EmployeeManagement;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.JobCardManagement
{
    public class JobCard : AuditInfo
    {
		public string TicketId { get; set; }
		public string EstimateId { get; set; }

		// Required
		public string JobcardNumber { get; set; }
		public DateTime JobcardDate { get; set; }

		// Optional
		public string ManualJobcardNumber { get; set; }

		public string AlternateContactPerson { get; set; }
		public string AlternateContactNumber { get; set; }


		// Excess
		public bool IsExcess { get; set; }
		public decimal ExcessAmount { get; set; }
		public bool IsExcessGenerated { get; set; }

		// Advance
		public bool IsAdvance { get; set; }
		public decimal AdvanceAmount { get; set; }
		public bool IsAdvanceGenerated { get; set; }

		// Amounts
		public decimal GrossAmount { get; set; }
		public decimal TaxAmount { get; set; }
		public decimal NetAmount { get; set; }

		// Notes
		public string CustomerComments { get; set; }
		public string JobDescription { get; set; }

		public JobCardStatus Status { get; set; }

		public virtual Ticket Ticket { get; set; }   // Navigation property
		public virtual Estimate Estimate { get; set; }
		public virtual Tenant? Tenant { get; set; }

		public virtual ICollection<JobCardItem> JobCardItems { get; set; }
		public virtual ICollection<JobcardStatusHistory>? JobcardStatusHistories { get; set; }
		public virtual ICollection<JobcardDocument>? JobcardDocuments { get; set; }

	}
}
