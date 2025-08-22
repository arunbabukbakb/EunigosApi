using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.VehicleTypes
{
    public class VehicleTypeRepository : Repository<VehicleType>, IVehicleTypeRepository
    {

        private ApplicationDbContext _db;
        public VehicleTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
