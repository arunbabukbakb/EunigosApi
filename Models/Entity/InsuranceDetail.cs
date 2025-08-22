using EunigosApi.Models.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EunigosApi.Models.Entity.CustomerManagement;

namespace EunigosApi.Models.Entity
{
    public class InsuranceDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [ForeignKey(nameof(CustomerVehicle))]
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

        public CustomerVehicle CustomerVehicle { get; set; }
    }
}
