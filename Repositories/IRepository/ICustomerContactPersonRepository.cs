using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.CustomerContactPersons
{
    public interface ICustomerContactPersonRepository : IRepository<CustomerContactPerson>
    {
		public Task<CustomerContactPerson> GetCustomerContactPersonByIdFromTicketAsync(string CustomerContactPersonId);

	}
}
