using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.RepairKitManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.OutsideWorkItems
{
    public class OutsideWorkItemRepository : Repository<OutsideWorkItem>, IOutsideWorkItemRepository
    {

        private ApplicationDbContext _db;
        public OutsideWorkItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
