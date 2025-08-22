using EunigosApi.Common;
using EunigosApi.Extensions;
using EunigosApi.Models.CommonModels;
using MediatR;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EunigosApi.Queries
{
    public class BaseListRepoQuery
    {
        public int Page { get; }
        public int Limit { get; }
        public int Start { get; }
        public int End { get; }
        public List<Filter> FilterList { get; }
        public List<SortOption> SortList { get; }
        public string? Includes { get; set; } = null;
    }
}
