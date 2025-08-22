
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Models.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace EunigosApi.Models.Entity.CustomerManagement
{
    public class CustomerVehicle : AuditInfo
    {
        [ForeignKey("CustomerId")]
        public string CustomerId { get; set; }
        public string VehicleNumber { get; set; }
        public string VehicleManufacturerId { get; set; }
        public string VehicleModelId { get; set; }
        public string Year { get; set; }
        public string VINNumber { get; set; }
        public string VehicleTypeId { get; set; }
        public string EngineCode { get; set; }
        public string FuelType { get; set; }
        public bool IsPrimary { get; set; }
		public decimal EngineCapacity { get; set; }
		public EngineCapacityMeasurement EngineMeasurement { get; set; }


		// Navigation Properties
		public virtual Tenant Tenant_Nav { get; set; }
        public virtual Customer Customer_Nav { get; set; }        
        public virtual VehicleManufacturer VehicleManufacturers { get; set; }
        public virtual VehicleModel VehicleModels { get; set; }
        public virtual VehicleType VehicleTypes { get; set; }
        public virtual InsuranceDetail InsuranceDetail { get; set; }
   
    }
}
