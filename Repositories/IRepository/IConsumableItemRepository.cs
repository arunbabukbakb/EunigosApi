using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.RepairKitManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.ConsumableItems
{
    public interface IConsumableItemRepository : IRepository<ConsumableItem>
    {
    }
}
