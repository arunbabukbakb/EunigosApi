using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.Common;

public class RepairType : AuditInfo
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string CustomerCategoryId { get; set; }
    public string Description { get; set; }

    public CustomerCategory CustomerCategory { get; set; }
}
