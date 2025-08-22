using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.RepairKitManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;
namespace EunigosApi.Repositories.RepairTypes
{
    public class RepairTypeRepository : Repository<RepairType>, IRepairTypeRepository
    {

        private ApplicationDbContext _db;
        public RepairTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
