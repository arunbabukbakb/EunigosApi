using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Models.Entity.VehicleManagement;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EunigosApi.Models.Entity.UserManagement
{
    public class User : AuditInfo
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? NickName { get; set; }
        public string? Photo { get; set; }
        public string? Sign { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiryTime { get; set; }
        public string RoleId { get; set; } = string.Empty;
        public DateTime? LastLoggedIn { get; set; }
        public int PasswordExpiryPeriod { get; set; }
        public bool ForcePasswordChange { get; set; }
        public bool IsSystemDefined { get; set; }
        public string? Email { get; internal set; }
    }
}
