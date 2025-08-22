using EunigosApi.Data;
using EunigosApi.Extensions;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Queries;
using EunigosApi.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EunigosApi.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<PagedResult<TEntity>> GetListAsync(BaseListRepoQuery request, CancellationToken cancellationToken)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            // Includes
            if (!string.IsNullOrWhiteSpace(request.Includes))
            {
                foreach (var includeProp in request.Includes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }

            foreach (var filter in request.FilterList)
            {
                query = QueryableExtensions.ApplyFilter(query, filter);
            }
            foreach (var sort in request.SortList)
            {
                query = QueryableExtensions.ApplySorting(query, sort);
            }

            var totalCount = await query.CountAsync(cancellationToken);

            var items = await query
                .Skip((request.Page - 1) * request.Limit)
                .Take(request.Limit)
                .ToListAsync(cancellationToken);

            return new PagedResult<TEntity>
            {
                Items = items,
                TotalItems = totalCount,
                PageNumber = request.Page,
                PageSize = request.Limit,
                Start=request.Start,
                End=request.End
            };
        }
        public virtual async Task<TEntity> GetByIdAsync(string id,string includes, CancellationToken cancellationToken)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            // Includes
            if (!string.IsNullOrWhiteSpace(includes))
            {
                foreach (var includeProp in includes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }

            var entity = await query.FirstOrDefaultAsync(e => EF.Property<object>(e, "Id").Equals(id), cancellationToken);

            if (entity == null)
                return null;

            // Map entity → DTO (assuming AutoMapper or manual mapping)
            return entity;
        }


        public async Task<TEntity?> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>>? filter, string? includeProperties = null)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!string.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }

            return await query.FirstOrDefaultAsync();
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteRangeHardAsync(IEnumerable<TEntity> entities)
        {
            _dbContext.RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public virtual async Task<bool> DeleteAsync(string id, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(new object?[] { Guid.Parse(id) }, cancellationToken);

            if (entity == null)
                return false;

            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<bool> DeactivateAsync(string id, string deletedById, CancellationToken cancellationToken)
        {
            // Try to find entity by primary key
            var entity = await _dbContext.Set<TEntity>().FindAsync(new object?[] { id }, cancellationToken);

            if (entity == null)
                return false;

            var entry = _dbContext.Entry(entity);

            // Soft-delete flags (check existence dynamically)
            if (entry.Properties.Any(p => p.Metadata.Name == "IsActive"))
                entry.Property("IsActive").CurrentValue = false;

            if (entry.Properties.Any(p => p.Metadata.Name == "IsDeleted"))
                entry.Property("IsDeleted").CurrentValue = true;

            if (entry.Properties.Any(p => p.Metadata.Name == "DeletedAt"))
                entry.Property("DeletedAt").CurrentValue = DateTime.UtcNow;

            if (entry.Properties.Any(p => p.Metadata.Name == "DeletedById"))
                entry.Property("DeletedById").CurrentValue = deletedById;

            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
