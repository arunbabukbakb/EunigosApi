using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.EstimateDocuments
{
    public class EstimateDocumentRepository : Repository<EstimateDocument>, IEstimateDocumentRepository
    {

        private ApplicationDbContext _db;
        public EstimateDocumentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<List<EstimateDocument>> AddEstimateDocumentAsync(List<EstimateDocument> estimateDocumentDetails)
        {
            throw new NotImplementedException();
        }
    }
}
