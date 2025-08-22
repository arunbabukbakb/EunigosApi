using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace EunigosApi.Models.Entity.VehicleManagement
{
    public class VehicleType : AuditInfo
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public virtual Tenant Tenant_Nav { get; set; }

        public ICollection<CustomerVehicle> customerVehicles { get; set; }

    }
}
