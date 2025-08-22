namespace EunigosApi.Models.Entity.Common
{
    public class City : AuditInfo
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string StateId { get; set; }
        public State State { get; set; }
    }
}
