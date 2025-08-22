using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.VehicleInventories
{
    public class VehicleInventoryRepository : Repository<VehicleInventory>, IVehicleInventoryRepository
    {

        private ApplicationDbContext _db;
        public VehicleInventoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
