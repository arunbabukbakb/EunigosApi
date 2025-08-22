using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.CustomerContactPersons
{
    public class CustomerContactPersonRepository : Repository<CustomerContactPerson>, ICustomerContactPersonRepository
    {

        private ApplicationDbContext _db;
        public CustomerContactPersonRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<CustomerContactPerson> GetCustomerContactPersonByIdFromTicketAsync(string CustomerContactPersonId)
        {
            throw new NotImplementedException();
        }
    }
}
