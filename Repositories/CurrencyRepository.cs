using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Queries;
using EunigosApi.Repositories.ConsumableItems;
using EunigosApi.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EunigosApi.Repositories.Currencies
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {

        private ApplicationDbContext _db;
        public CurrencyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
