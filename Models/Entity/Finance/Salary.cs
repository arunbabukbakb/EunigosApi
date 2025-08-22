using EunigosApi.Models.Entity.EmployeeManagement;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EunigosApi.Models.Entity.Finance
{
    public class Salary : AuditInfo
    {
       public string EmployeeId { get; set; }

       public decimal BasicAmount { get; set; }

       public decimal AllowanceAmount { get; set; }

       public decimal? OtherAmount { get; set; }

       public string SalaryTypeId { get; set; }

       public string PaymentMode { get; set; }

       public int PayPeriod { get; set; }

       public bool HasOvertime { get; set; }

        // Navigation Properties
       public Employee Employee { get; set; }

       public SalaryType SalaryType { get; set; }

    }
}
