using EunigosApi.Models.Entity.CustomerManagement;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EunigosApi.Models.Entity.VehicleManagement
{
    public class VehicleModel : AuditInfo
    {
        [Required]
        [ForeignKey("VehicleManufacturer")]
        public string ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }       

        // Navigation properties
        public virtual VehicleManufacturer Manufacturer_Nav { get; set; }
        public virtual Tenant Tenant_Nav { get; set; }

        public ICollection<CustomerVehicle> customerVehicles { get; set; }
    }
}
