using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.PartManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.PartManagement.ItemService
{
    public class ItemServicesRepository : Repository<ItemServices>, IItemServicesRepository
    {

        private ApplicationDbContext _db;
        public ItemServicesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
