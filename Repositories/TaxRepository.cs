using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.Finance;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Taxes
{
    public class TaxRepository : Repository<Tax>, ITaxRepository
    {

        private ApplicationDbContext _db;
        public TaxRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task DeactivateAllTaxesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tax> GetActiveTaxAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsTaxCodeUniqueAsync(string code, string excludeId = null)
        {
            throw new NotImplementedException();
        }
    }
}
