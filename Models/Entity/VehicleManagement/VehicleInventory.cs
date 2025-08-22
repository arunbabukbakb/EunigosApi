using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.TicketManagement;
using System.ComponentModel.DataAnnotations.Schema;


namespace EunigosApi.Models.Entity.VehicleManagement
{
    public class VehicleInventory : AuditInfo
    {
        public string ItemName { get; set; }
        public virtual Tenant Tenant_Nav { get; set; }

      // public VehicleInspection VehicleInspection { get; set; }

    }
}
