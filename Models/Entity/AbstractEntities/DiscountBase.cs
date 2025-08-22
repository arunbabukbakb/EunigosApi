using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.AbstractEntities
{
    public abstract class DiscountBase : AuditInfo
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public EstimateDiscountType Type { get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? MaxUsage { get; set; }
        public int CurrentUsage { get; set; }
        public decimal? MinPurchaseAmount { get; set; }
        public decimal? MaxDiscountAmount { get; set; }
    }
}
