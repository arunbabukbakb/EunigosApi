using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EunigosApi.Models.Entity
{
    public class AuditInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string TenantId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? CreatedById { get; set; } // foreign key
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedById { get; set; }// foreign key
        public DateTime? DeletedAt { get; set; }
        public string? DeletedById { get; set; } // foreign key
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
    }
}
