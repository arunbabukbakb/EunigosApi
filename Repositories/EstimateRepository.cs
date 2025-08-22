using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace EunigosApi.Repositories.Estimates
{
    public class EstimateRepository : Repository<Estimate>, IEstimateRepository
    {

        private ApplicationDbContext _db;
        public EstimateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<int> GetClonedEstimateCountByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetClonesCountAsync(string parentEstimateNumber)
        {
            throw new NotImplementedException();
        }

        public Task<List<Estimate>> GetEstimatesByNumberPrefixAsync(string prefix)
        {
            throw new NotImplementedException();
        }

        public Task<Estimate> GetOldEstimateByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
