namespace EunigosApi.Models.Entity.AbstractEntities
{
    public abstract class InventoryItemBase : AuditInfo
    {
        public string Name { get; set; }

        public string ItemCode { get; set; }

        public string? Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
