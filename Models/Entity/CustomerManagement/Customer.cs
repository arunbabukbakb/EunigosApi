using EunigosApi.Models.Entity.Common;

namespace EunigosApi.Models.Entity.CustomerManagement
{
	public class Customer : AuditInfo
	{
		#region New Fields
		public int CustomerCode { get; set; }
		public string CustomerCategoryId { get; set; }
		public string CustomerCodeFormatted { get; set; }
		public string Salutation { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string CountryId { get; set; }
		public string StateId { get; set; }
		public string City { get; set; }
		public string Zipcode { get; set; }
		public string ContactNumber1 { get; set; }
		public string ContactNumber2 { get; set; }
		public string EmailId { get; set; }
		public string Photo { get; set; } // base64 encoded string
		public bool? IsCreditPeriodApplicable { get; set; }
		public int? CreditPeriod { get; set; }
		public decimal? CreditAmount { get; set; }
		public int? LockPeriod { get; set; }
		public decimal? LockAmount { get; set; }
		public decimal? VAT { get; set; } // service tax
		public string TRNGSTNumber { get; set; }
		public string PaymentTerms { get; set; }
		public TimeSpan? AvailabilityOfTime { get; set; }
		public bool? Status { get; set; }
		#endregion

		public Tenant Tenant_Nav { get; set; }
		public CustomerCategory customerCategory { get; set; }
		public virtual Country Country { get; set; }
		public virtual State State { get; set; }
		// Navigation Collections
		public ICollection<CustomerContactPerson> CustomerContactPersons { get; set; } = new List<CustomerContactPerson>();

	}

}