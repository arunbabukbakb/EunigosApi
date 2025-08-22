using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.Customers
{
    public interface ICustomerRepository:IRepository<Customer>
    {
		Task<int> GetLatestCustomerCodeAsync();
	}
}
