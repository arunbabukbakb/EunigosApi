using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Repositories.Countries;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Customers
{

    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        private ApplicationDbContext _db;
        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<int> GetLatestCustomerCodeAsync()
        {
            return await _db.Customers
                .OrderByDescending(c => c.CustomerCode)
                .Select(c => c.CustomerCode)
                .FirstOrDefaultAsync();
        }
    }
}
