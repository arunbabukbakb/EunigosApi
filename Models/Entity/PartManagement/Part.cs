using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.PartManagement
{
    public class Part : AuditInfo
    {
        public PartCategory Category { get; set; }
        public bool IsLotControlled { get; set; }
        public bool IsSerialized { get; set; }
        public string ManufacturerId { get; set; }
        public int MaxStockLevel { get; set; }
        public int MinStockLevel { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public int ReorderLevel { get; set; }
        public string UnitId { get; set; }
        public string? Barcode { get; set; }
        public string? DefaultLocationId { get; set; }
        public string? Description { get; set; }
        public string? Dimensions { get; set; }
        public string? Notes { get; set; }
        public string? OemNumber { get; set; }
        public string? PhotoUrls { get; set; } // JSON array of URLs
        public int? ShelfLifeMonths { get; set; }
        //public string TechnicalSpecs { get; set; }
        public int? WarrantyPeriod { get; set; }

        public decimal? Weight { get; set; }
        public Tenant Tenant { get; set; }
    }
}

