using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class EstimateApprovalDto 
    {
        public string Id { get; set; }
        public string? EstimateId { get; set; }

        public ApprovalStatus Status { get; set; }

        public string? ApprovedById { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public decimal? ApprovedAmount { get; set; }

        public string? ApprovalNotes { get; set; }

        public string? ApprovedNumber { get; set; } 

        public string? ApprovalMethod { get; set; }

        public decimal? ApprovalTaxAmount { get; set; }

        public decimal? NetApprovedAmount { get; set; }

        public string? RevertedById { get; set; }
        public DateTime? RevertDate { get; set; }
        public string? RevertNotes { get; set; }
        public string? RevertedMethod { get; set; }



        public string? ArchivedById { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public string? ReasonOfArchive { get; set; }

        public string TenantId { get; set; }
    }
}
