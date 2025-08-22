using EunigosApi.Models.Entity.AbstractEntities;

namespace EunigosApi.Models.Entity.Common
{
    public class ConsumableItem : InventoryItemBase
    {
        public string UnitOfMeasure { get; set; }

        public int StockQuantity { get; set; }
    }
}
