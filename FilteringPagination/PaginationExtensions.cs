using EunigosApi.Models.CommonModels;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.FilteringPagination
{
    public static class PaginationExtensions
    {
        public static async Task<PagedResult<TEntity>> ApplyPaginationAsync<TEntity>(
            this IQueryable<TEntity> query,
            int pageNumber,
            int pageSize,
            int start,
            int end)
        {
            var totalItems = await query.CountAsync();
            var items = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            if(start> 0 && end >0)
            {
                // Ensure start and end are within the bounds of the list size
                int adjustedStart = start - 1; // Convert to zero-based index
                int adjustedEnd = Math.Min(end, items.Count); // Ensure 'end' doesn't exceed list size

                // Ensure adjustedStart is not greater than list size
                if (adjustedStart < items.Count)
                {
                    // Convert start and end to zero-based indexes and slice the list
                    items = items.Skip(adjustedStart).Take(adjustedEnd - adjustedStart).ToList();

                }
            }

            return new PagedResult<TEntity>
            {
                Items = items,
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Start = start,
                End = end
            };
        }
    }

}
