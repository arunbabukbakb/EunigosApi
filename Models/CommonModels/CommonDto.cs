namespace EunigosApi.Models.CommonModels
{
    public class CommonDto
    {
        public bool IsActive { get; set; }
        public string CreatedById { get; set; }
        public string UpdatedById { get; set; }
        public string DeletedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        //public string TenantId { get; set; }
    }
}
