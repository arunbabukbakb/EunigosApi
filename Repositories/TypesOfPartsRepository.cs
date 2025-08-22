using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.PartManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.PartManagement.TypesOfPart
{
    public class TypesOfPartsRepository : Repository<TypesOfParts>, ITypesOfPartsRepository
    {

        private ApplicationDbContext _db;
        public TypesOfPartsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
