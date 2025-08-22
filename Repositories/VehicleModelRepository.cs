using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.VehicleModels
{
    public class VehicleModelRepository : Repository<VehicleModel>, IVehicleModelRepository
    {

        private ApplicationDbContext _db;
        public VehicleModelRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
