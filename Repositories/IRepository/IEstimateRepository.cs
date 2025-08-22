using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.Estimates
{
    public interface IEstimateRepository : IRepository<Estimate>
    {
        public Task<int> GetClonedEstimateCountByIdAsync(string Id);
        Task<int> GetClonesCountAsync(string parentEstimateNumber);
        Task<List<Estimate>> GetEstimatesByNumberPrefixAsync(string prefix);
		public Task<Estimate> GetOldEstimateByIdAsync(string Id);

	}
}
