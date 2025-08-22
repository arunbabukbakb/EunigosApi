using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.Finance;
using EunigosApi.Models.Entity.TicketManagement;

namespace EunigosApi.Models.Entity.EmployeeManagement
{
    public class Employee : AuditInfo
    {
        public string UserId { get; set; }
        public string EmployeeCode { get; set; }
        public string DepartmentId { get; set; }
        public string DesignationId { get; set; }
        public string OrganizationUnitId { get; set; }
        public string SalaryId { get; set; }
        public string PersonalId { get; set; }
        public string EmployeeDetailId { get; set; }
        public string AdditionalInfoId { get; set; }
        public string? Grade { get; set; }

        //Navigation
        public virtual Tenant Tenant_Nav { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public Salary Salary { get; set; }
    }
}
