using EunigosApi.Common;
using MediatR;

namespace EunigosApi.Commands
{
    public class BaseDeleteCommand<TEntity> : IRequest<ApiResponse3>
    where TEntity : class
    {
        public string Id { get; }

        public BaseDeleteCommand(string id)
        {
            Id = id;
        }
    }
}
