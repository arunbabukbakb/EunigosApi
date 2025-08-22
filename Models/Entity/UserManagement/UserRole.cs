using Microsoft.AspNetCore.Identity;
using EunigosApi.Models.Entity.UserManagement;

namespace EunigosApi.Models.Entity;

public class UserRole : AuditInfo
{
    public string UserId { get; set; }
    public string RoleId { get; set; }
    public virtual User User { get; set; }
    public virtual Role Role { get; set; }
}