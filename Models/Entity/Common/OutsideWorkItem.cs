using EunigosApi.Models.Entity.AbstractEntities;

namespace EunigosApi.Models.Entity.RepairKitManagement
{
    public class OutsideWorkItem :AuditInfo
    {
        public string Name { get; set; }

        public string ItemCode { get; set; }

        public string? Description { get; set; }

        //navigation
        public virtual Tenant Tenant_Nav { get; set; }
    }
}
