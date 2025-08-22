using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.VehicleServiceManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Serviceitems
{
    public class ServiceItemRepository : Repository<ServiceItem>, IServiceItemRepository
    {

        private ApplicationDbContext _db;
        public ServiceItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
