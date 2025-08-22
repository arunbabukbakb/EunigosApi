using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Models.Entity.UserManagement;

namespace EunigosApi.Models.Entity.VehicleManagement
{
    public class VehicleInspection : AuditInfo
    {
        public string TicketId { get; set; }
        public double OdometerReading { get; set; }
        public string MeterReadingType { get; set; }
        public string InspectionComments { get; set; }
        public List<string> InventoryItems { get; set; } = new();
        public string? InventoryNotes { get; set; }
        public string? CustomerSignature { get; set; }
        public double FuelLevel { get; set; }
        public string FuelTypeId { get; set; }
        public string? TechnicianId { get; set; }
        public User Technician { get; set; }
       
        public Ticket Ticket { get; set; }
        public Tenant Tenant_Nav { get; set; }
        public ICollection<VehicleInspectionItem> VehicleInspectionItems { get; set; }
        public ICollection<InspectionMedia> InspectionMedias { get; set; }
        public FuelType FuelType { get; set; }
    }

}
