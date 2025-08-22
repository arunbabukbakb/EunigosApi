namespace EunigosApi.Models.Entity.VehicleManagement;

public class FuelType : AuditInfo
{
        public string Name { get; set; }
    public virtual VehicleInspection VehicleInspection { get; set; }
}
