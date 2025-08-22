using EunigosApi.Models.Entity.EstimateManagement;

namespace EunigosApi.Models.Entity.Finance
{
    public class Tax : AuditInfo
    {
        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool ActiveTax { get; set; }
    }
}
