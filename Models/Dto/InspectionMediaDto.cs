using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class InspectionMediaDto
    {
        public string Id { get; set; }
        public string InspectionId { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbNailUrl { get; set; }
        public string Type { get; set; }//image or video
    }
}
