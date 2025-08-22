using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Finance;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.Taxes
{
    public interface ITaxRepository : IRepository<Tax>
    {        
        // New methods for active tax management
        Task<Tax> GetActiveTaxAsync();
        Task DeactivateAllTaxesAsync();
        Task<bool> IsTaxCodeUniqueAsync(string code, string excludeId = null);
    }
}