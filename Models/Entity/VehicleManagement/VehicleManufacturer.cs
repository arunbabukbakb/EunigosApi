using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using System.ComponentModel.DataAnnotations;

namespace EunigosApi.Models.Entity.VehicleManagement
{
    public class VehicleManufacturer : AuditInfo
    {
        public string Name { get; set; }
        [Url]
        public virtual Tenant Tenant_Nav { get; set; }
    

       public ICollection<VehicleModel> VehicleModels { get; set; }
        public ICollection<CustomerVehicle> customerVehicles { get; set; }
    }
}
