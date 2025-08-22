using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Roles;

public class RoleRepository : Repository<Role>, IRoleRepository
{

    private ApplicationDbContext _db;
    public RoleRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}



