using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Manufactures
{
    public class ManufacturerRepository : Repository<Manufacturer>, IManufacturerRepository
    {

        private ApplicationDbContext _db;
        public ManufacturerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
