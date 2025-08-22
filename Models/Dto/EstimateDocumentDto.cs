using EunigosApi.Models.CommonModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class EstimateDocumentDto 
    {
        public string EstimateId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string FilePath { get; set; }
        public string? Notes { get; set; }
        public string TenantId { get; set; }

    }
}
