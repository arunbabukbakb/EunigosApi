using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EunigosApi.Models.Entity.VehicleManagement
{
    public class InspectionMedia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [ForeignKey("VehicleInspection")]
        public string InspectionId { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public string? ThumbNailUrl { get; set; }
        public string Type { get; set; }//image or video
        [JsonIgnore]
        public virtual VehicleInspection VehicleInspection { get; set; }
    }
}
