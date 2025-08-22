using EunigosApi.Models.Entity.AbstractEntities;

namespace EunigosApi.Models.Entity.VehicleServiceManagement
{
    public class ServiceItem : InventoryItemBase
    {
        public long Duration { get; set; }
        public bool IsFlatRate { get; set; }
     

        //navigation
        public virtual Tenant Tenant_Nav { get; set; }
    }
}
