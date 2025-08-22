using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EunigosApi.Models.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class EstimateItemDto
    {
        public string Id { get; set; }

        public string? EstimateId { get; set; }

        public string ItemId { get; set; }
        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public string TaxId { get; set; }

        public decimal TaxAmount { get; set; }

        public EstimateDiscountType DiscountType { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal TotalAmount { get; set; }

        public string DescriptionOfItem { get; set; }

        public bool IsHide { get; set; }
        public string EstimateItemSide {  get; set; }   
        public decimal GrossAmount {  get; set; }
        public string ItemCategory {  get; set; }

        public string ItemService { get; set; }
        public string SourceOfPart { get; set; }
        public string TypesOfPart { get; set; }
        public decimal NetAmount { get; set; }

    }
}
