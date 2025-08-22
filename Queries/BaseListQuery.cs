using EunigosApi.Common;
using EunigosApi.Extensions;
using EunigosApi.Models.CommonModels;
using MediatR;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EunigosApi.Queries
{
    public class BaseListQuery<TEntity, TDto> : IRequest<ApiResponse3>
        where TEntity : class
        where TDto : class
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 10;
        private const int DefaultPageStart = 1;
        private const int DefaultPageEnd = 10;

        public int Page { get; } = DefaultPageNumber;
        public int Limit { get; } = DefaultPageSize;
        public int Start { get; } = DefaultPageStart;
        public int End { get; } = DefaultPageEnd;
        public List<Filter> FilterList { get; }
        public List<SortOption> SortList { get; }

        public string? Includes { get; set; } = null;

        public BaseListQuery(int page, int limit, int start, int end, List<Filter> filterList, List<SortOption> sortList, string? includes = null)
        {
            Page = page > 0 ? page : DefaultPageNumber;
            Limit = limit > 0 ? limit : DefaultPageSize;
            Start = start > 0 ? start : DefaultPageStart;
            End = end > 0 ? end : DefaultPageEnd;
            FilterList = filterList ?? new List<Filter>();
            SortList = sortList ?? new List<SortOption>();
            Includes = includes;
        }
    }
}
