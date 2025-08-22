using EunigosApi.Models.Entity.Finance;
using EunigosApi.Models.Entity.PartManagement;
using System.ComponentModel.DataAnnotations.Schema;

namespace EunigosApi.Models.Entity.JobCardManagement
{
    public class JobCardItem : AuditInfo
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Id { get; set; } = Guid.NewGuid().ToString();
		public string JobCardId { get; set; }
		// Item details
		public string ItemId { get; set; }
		public string ItemCategory { get; set; }
		public string? Notes { get; set; }             // Description_Of_Parts
		public string? TypesOfParts { get; set; }
		public string? SourceOfParts { get; set; }
		public string? ItemSide { get; set; }
		public string? Service { get; set; }

		// Quantity & Pricing
		public decimal ActualQuantity { get; set; }
		public decimal ActualPrice { get; set; }
		public decimal GrossAmount { get; set; }
		public int DiscountType { get; set; }
		public decimal DiscountValue { get; set; }
		public decimal DiscountAmount { get; set; }
		public decimal TotalAmount { get; set; }

		// Tax
		public string TaxId { get; set; }
		public decimal TaxAmount { get; set; }
		public decimal NetAmount { get; set; }

		// Flags
		public bool IsHide { get; set; }
		public bool IsDeleted { get; set; }
		public decimal IssuedQuantity { get; set; }

		//Navigation

		public virtual JobCard JobCard { get; set; }
		public Tax Tax { get; set; }
		public TypesOfParts? TypesOfPart { get; set; }
		public SourceOfParts? SourceOfPart { get; set; }
		public ItemServices? ItemServices { get; set; }
	}
}
