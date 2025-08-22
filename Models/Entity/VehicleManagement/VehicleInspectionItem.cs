using EunigosApi.Models.Entity;
using EunigosApi.Models.Entity.VehicleManagement;
using System.ComponentModel.DataAnnotations.Schema;

public class VehicleInspectionItem : AuditInfo
{
    [ForeignKey("VehicleInspection")]
    public string InspectionId { get; set; }
    public string ItemName { get; set; }
    public string Condition { get; set; }
    public string Notes { get; set; }
    public bool IsAvailable { get; set; }
    //[ForeignKey("Tenant")]
    //public string TenantId { get; set; }

    //Navigation
    public virtual Tenant Tenant_Nav { get; set; }
    public virtual VehicleInspection VehicleInspection_Nav { get; set; }


}
