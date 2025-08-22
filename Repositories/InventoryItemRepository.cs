using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.InventoryItems
{
    public class InventoryItemRepository : Repository<VehicleInventoryItem>, IInventoryItemRepository
    {

        private ApplicationDbContext _db;
        public InventoryItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
    }
}
