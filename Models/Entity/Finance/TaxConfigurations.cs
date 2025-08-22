using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EunigosApi.Models.Entity.Finance
{
    public class TaxConfigurations : AuditInfo
    {
      
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool? IsCompound { get; set; }
        public double? Rate { get; set; }
        public Tenant Tenant { get; set; }
    }
}
