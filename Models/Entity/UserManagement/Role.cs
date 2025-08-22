using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunigosApi.Models.Entity.UserManagement
{
    public class Role:AuditInfo
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string RoleCode { get; set; }
    }
}
