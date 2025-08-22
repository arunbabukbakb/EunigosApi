using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.EstimateItems
{
    public class EstimateItemRepository : Repository<EstimateItem>, IEstimateItemRepository
    {

        private ApplicationDbContext _db;
        public EstimateItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

        public Task<List<EstimateItem>> AddEstimateItemAsync(List<EstimateItem> EstimateItems)
        {
            throw new NotImplementedException();
        }
    }
}