using EunigosApi.Common;
using MediatR;

namespace EunigosApi.Queries
{
    public class BaseIdQuery<TEntity, TDto> : IRequest<ApiResponse3>
        where TEntity : class
        where TDto : class
    {
        public string Id { get; }

        public string? Includes { get; set; }

        public BaseIdQuery(string id, string? includes = null)
        {
            Id = id;
            Includes = includes;
        }
    }
}
