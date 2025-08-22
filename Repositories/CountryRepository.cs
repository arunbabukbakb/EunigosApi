using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.UserManagement;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Countries
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {

        private ApplicationDbContext _db;
        public CountryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
    
}
