using System.ComponentModel.DataAnnotations;

namespace EunigosApi.Models.Entity.Finance
{
    public class SalaryType: AuditInfo
    {
        public string Name { get; set; }        
        public string Description { get; set; }
        public ICollection<Salary> Salary { get; set; }
    }
}
