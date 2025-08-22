using EunigosApi.Models.Entity.TicketManagement;

namespace EunigosApi.Models.Entity.Common
{
    public class JobType : AuditInfo
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        // public string TenantId { get; set; }

        // Navigation property for Tenant
        public virtual Tenant Tenant_Nav { get; set; }
        
    }
}
