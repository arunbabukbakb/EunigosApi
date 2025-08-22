
namespace EunigosApi.Models.Entity.CustomerManagement
{
	public class CustomerContactPerson : AuditInfo
	{
		public string CustomerId { get; set; }
		public string Salutation { get; set; }
		public string Name { get; set; }
		public string ContactNumber { get; set; }
		public string Email { get; set; }
		public string? NIDNumber { get; set; }
		public string? LicenseNumber { get; set; }

		//Navigation Property
		public Tenant Tenant_Nav { get; set; }
		public Customer Customer_Nav { get; set; }
		public virtual ICollection<CustomerVehicle> Vehicles { get; set; }

	}
}
