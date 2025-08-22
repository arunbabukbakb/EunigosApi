using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.InventoryItems
{
    public interface IInventoryItemRepository : IRepository<VehicleInventoryItem>
    {
    }
}

