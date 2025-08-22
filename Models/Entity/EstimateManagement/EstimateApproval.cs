using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.EstimateManagement
{
    public class EstimateApproval : AuditInfo
    {
        public string EstimateId { get; set; }

        public ApprovalStatus Status { get; set; }

        public string? ApprovedById { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public decimal? ApprovedAmount { get; set; }

        public string? ApprovalNotes { get; set; }

        public string? ApprovedNumber { get; set; } //New

        public string? ApprovalMethod { get; set; }//New

        public decimal? ApprovalTaxAmount { get; set; }//New

        public decimal? NetApprovedAmount { get; set; }//New


        public string? RevertedById { get; set; }
        public DateTime? RevertDate { get; set; }
        public string? RevertNotes { get; set; }
        public string? RevertedMethod { get; set; }



        public string? ArchivedById { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public string? ReasonOfArchive { get; set; }



        // Navigation Properties

        public Estimate EstimateModel { get; set; } // Associated estimate
        public virtual Tenant Tenant_Nav { get; set; }
        public User? ArchivedBy { get; set; }
        public User? ApprovedBy { get; set; }
        public User? RevertedBy { get; set; }
    }
}
