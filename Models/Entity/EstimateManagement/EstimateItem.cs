using EunigosApi.Models.Entity.Finance;
using EunigosApi.Models.Entity.PartManagement;
using EunigosApi.Models.Enum;

namespace EunigosApi.Models.Entity.EstimateManagement
{
    public class EstimateItem : AuditInfo
    {
        public string? EstimateId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }// "Inventory", "Service", "Consumable", "Outside"
		public string? DescriptionOfItem { get; set; }
		public string? TypesOfPart { get; set; }
		public string? SourceOfPart { get; set; }
		public ItemSide? EstimateItemSide { get; set; }
		public string? ItemService { get; set; }
		public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
		public decimal? GrossAmount { get; set; }
		public EstimateDiscountType? DiscountType { get; set; }
		public decimal? DiscountValue { get; set; }
		public decimal? DiscountAmount { get; set; }
		public string? TaxId { get; set; }
        public decimal? TaxAmount { get; set; }     
        public decimal? TotalAmount { get; set; }
		public decimal? NetAmount { get; set; }
		public bool IsHide { get; set; }=false;
        public Tax Tax_Nav { get; set; }
		public Estimate Estimate_Nav { get; set; }
		public TypesOfParts TypeOfParts_Nav { get; set; }
		public SourceOfParts SourceOfPart_Nav { get; set; }
		public ItemServices ItemServices_Nav { get; set; }

	}
}
