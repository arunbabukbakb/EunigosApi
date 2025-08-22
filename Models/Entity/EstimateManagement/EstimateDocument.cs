namespace EunigosApi.Models.Entity.EstimateManagement
{
    public class EstimateDocument : AuditInfo
    {
        public string EstimateId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string FilePath { get; set; }
        public string? Notes { get; set; }
        //public string TenantId { get; set; }

        public virtual Estimate Estimate_Nav { get; set; }
        public virtual Tenant Tenant_Nav { get; set; }
    }

}
