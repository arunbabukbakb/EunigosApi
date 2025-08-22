
namespace EunigosApi.Models.Entity.CustomerManagement
{
	public class CustomerCategory : AuditInfo
	{
		public string Name { get; set; }
		public string CategoryCode { get; set; }
		public string Description { get; set; }
		public string? ParentId { get; set; }

		// Navigation
		public Tenant Tenant_Nav { get; set; }
		public ICollection<Customer> Customers { get; set; } // Many-to-Many relationship with Customers
		public CustomerCategory? ParentCategory { get; set; } // Navigation property to parent category
		public ICollection<CustomerCategory> ChildCategories { get; set; } // Updated name to avoid confusion
	}
}
