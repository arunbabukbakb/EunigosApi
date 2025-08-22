using EunigosApi.Models.Entity;

namespace EunigosApi.Models
{
    public class Currency : AuditInfo
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Symbol { get; set; }


    }
}
