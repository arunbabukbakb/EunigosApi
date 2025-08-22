using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Repositories.EstimateDocuments
{
    public interface IEstimateDocumentRepository : IRepository<EstimateDocument>
    {
		public Task<List<EstimateDocument>> AddEstimateDocumentAsync(List<EstimateDocument> estimateDocumentDetails);// save list of documents

	}
}
