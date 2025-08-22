namespace EunigosApi.Models.Entity
{
    public class Tenant : AuditInfo
    {

        public string Name { get; set; }
        public string Domain { get; set; }
        public string UserProfileCategoryId { get; set; }
    }
}
