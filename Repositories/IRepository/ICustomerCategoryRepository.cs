using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.CustomerCategories
{
    public interface ICustomerCategoryRepository : IRepository<CustomerCategory>
    {
        public Task<int> GetCategoryCountAsync();  // Counts total categories
        public Task<bool> ExistsAsync(string categoryId);  // Checks if a category exists by ID
		Task<string> GetCustomerCategoryCodeByIdAsync(string categoryId);
	}
}
