namespace EunigosApi.Models.Entity;

public class Permission : AuditInfo
{
        public string Action { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string? Conditions { get; set; } 
        public string? Description { get; set; }
        public bool? Inverted { get; set; }
        public string? Reason { get; set; }
        public Tenant Tenant { get; set; }
}
