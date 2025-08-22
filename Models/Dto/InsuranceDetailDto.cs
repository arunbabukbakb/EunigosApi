using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class InsuranceDetailDto : CommonDto
    {
        public string Id { get; set; }
        public string CustomerVehicleId { get; set; }
        public ClaimType? CoverageType { get; set; }
        public string? ClaimNumber { get; set; }
        public DateTime? LpoDate { get; set; }
        public string? LpoNumber { get; set; }
        public string? PoliceReportNumber { get; set; }
        public string? Emirates { get; set; }
        public string? PolicyNumber { get; set; }
        public DateTime? CreditNoteDate { get; set; }
        public string? CreditNoteNumber { get; set; }
        public DateTime? AccidentDate { get; set; }
    }
}
