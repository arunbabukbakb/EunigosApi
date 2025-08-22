using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.CustomerCategories
{
    public class CustomerCategoryRepository : Repository<CustomerCategory>, ICustomerCategoryRepository
    {

        private ApplicationDbContext _db;
        public CustomerCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ExistsAsync(string categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCategoryCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetCustomerCategoryCodeByIdAsync(string categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
