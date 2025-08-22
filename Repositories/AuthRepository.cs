using EunigosApi.Data;
using EunigosApi.Models.Entity;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Repositories.Customers;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Auth
{
    public class AuthRepository : Repository<User>, IAuthRepository
    {

        private ApplicationDbContext _db;
        public AuthRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<User> StoreRefreshTokenAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
