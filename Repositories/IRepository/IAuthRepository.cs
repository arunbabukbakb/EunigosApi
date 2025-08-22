using EunigosApi.Models.Entity;
using EunigosApi.Models.Entity.UserManagement;

namespace EunigosApi.Repositories.Auth
{
    public interface IAuthRepository
    {
        public  Task<User> StoreRefreshTokenAsync(User user);
    }
}
