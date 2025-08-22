using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.EstimateItems
{
    public interface IEstimateItemRepository : IRepository<EstimateItem>
    {
        public Task<List<EstimateItem>> AddEstimateItemAsync(List<EstimateItem> EstimateItems);  // save list of estimate items
    }
}
