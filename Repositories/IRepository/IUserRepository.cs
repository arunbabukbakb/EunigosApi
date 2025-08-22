using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.Users
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
