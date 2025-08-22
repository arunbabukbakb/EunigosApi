using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.RepairKitManagement;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Repositories.Auth;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.ConsumableItems
{
    public class ConsumableItemRepository : Repository<ConsumableItem>, IConsumableItemRepository
    {

        private ApplicationDbContext _db;
        public ConsumableItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
