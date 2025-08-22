using EunigosApi.Models.CommonModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class CustomerContactPersonDto : CommonDto
	{
		public string Id { get; set; }
		public string CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string Salutation { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string ContactNumber { get; set; }
		public string TenantId { get; set; }
	}
}
