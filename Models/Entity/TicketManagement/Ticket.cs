using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.EmployeeManagement;
using EunigosApi.Models.Entity.JobCardManagement;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.TicketManagement
{
    public class Ticket : AuditInfo
    {
        /// <summary>
        /// Arun docs start
        /// </summary>
        public string TicketNumber { get; set; }
        public DateTime DropOffDate { get; set; }
        public string JobTypeId { get; set; }
        public string RepairTypeId { get; set; }
        public string CustomerContactPersonId { get; set; }
        public string AdvisorId { get; set; }
        public string CustomerId { get; set; }
        public string? OwnerId { get; set; }
        public string? CorporateId { get; set; }
        public DateTime? ExpectedPickupTime { get; set; }
        public string CustomerVehicleId { get; set; }
        public string? CustomerComments { get; set; }

        public TicketStatus? Status { get; set; }
        public string TenantId { get; set; }


        // Navigation properties for related models
        public virtual Tenant Tenant { get; set; }
        public virtual RepairType RepairType { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual User Advisor { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer? Owner { get; set; }
        public virtual Customer? Corporate { get; set; }
        public virtual CustomerContactPerson ContactPerson { get; set; }
        public virtual CustomerVehicle CustomerVehicle { get; set; }
        public VehicleInspection VehicleInspection { get; set; }
		public virtual JobCard JobCard { get; set; }

	}

}
