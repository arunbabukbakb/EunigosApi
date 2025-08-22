using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.Finance;
using EunigosApi.Repositories.Countries;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.States
{
    public class StateRepository : Repository<State>, IStateRepository
    {

        private ApplicationDbContext _db;
        public StateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
