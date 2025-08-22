using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.PartManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.PartManagement.SourceOfPart
{
    public class SourceOfPartsRepository : Repository<SourceOfParts>, ISourceOfPartsRepository
    {

        private ApplicationDbContext _db;
        public SourceOfPartsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
