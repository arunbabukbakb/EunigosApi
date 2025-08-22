using EunigosApi.Common;
using MediatR;

namespace EunigosApi.Commands
{
    public class BaseDeactivateCommand<TEntity> : IRequest<ApiResponse3>
    where TEntity : class
    {
        public string Id { get; }
        public string DeletedById { get; }

        public BaseDeactivateCommand(string id, string deletedById)
        {
            Id = id;
            DeletedById = deletedById;
        }
    }
}
