using EunigosApi.Commands;
using EunigosApi.Common;
using EunigosApi.Models;
using EunigosApi.Repositories.IRepository;
using MediatR;

namespace EunigosApi.Handlers
{
    public class BaseDeleteHandler<TEntity> : IRequestHandler<BaseDeleteCommand<TEntity>, ApiResponse3>
    where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public BaseDeleteHandler(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse3> Handle(BaseDeleteCommand<TEntity> request, CancellationToken cancellationToken)
        {
            var errors = new List<Error>();
            var success= await _repository.DeleteAsync(request.Id, cancellationToken);
            if (success)
                return new ApiResponse3(true, errors, "Entity marked as deleted successfully", null, null);

            errors.Add(new Error
            {
                Code = AppCodes.NotFoundActivity,
                Message = "Entity not found",
                Field = "Id"
            });

            return new ApiResponse3(false, errors, null, null, null);
        }
    }
}
