using EunigosApi.Models.CommonModels;
using EunigosApi.Queries;
using System.Linq.Expressions;

namespace EunigosApi.Repositories.IRepository
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<PagedResult<TEntity>> GetListAsync(BaseListRepoQuery request, CancellationToken cancellationToken);
        Task<TEntity?> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>>? filter, string? includeProperties = null);
        Task<TEntity> GetByIdAsync(string id, string includes, CancellationToken cancellationToken);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteRangeHardAsync(IEnumerable<TEntity> entities);
        Task<bool> DeleteAsync(string id, CancellationToken cancellationToken);
        Task<bool> DeactivateAsync(string id, string deletedById, CancellationToken cancellationToken);
    }
}
