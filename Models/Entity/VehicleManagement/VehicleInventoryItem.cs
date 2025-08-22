using System.ComponentModel.DataAnnotations.Schema;

namespace EunigosApi.Models.Entity.VehicleManagement
{
    public class VehicleInventoryItem : AuditInfo
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Condition { get; set; }
        public string Notes { get; set; }

        // Navigation property
        public Tenant Tenant_Nav { get; set; }
      

    }
}
