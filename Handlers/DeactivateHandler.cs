using EunigosApi.Commands;
using EunigosApi.Common;
using EunigosApi.Models;
using MediatR;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Handlers
{
    public class DeactivateHandler<TEntity> :
    IRequestHandler<BaseDeactivateCommand<TEntity>, ApiResponse3>
    where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public DeactivateHandler(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse3> Handle(BaseDeactivateCommand<TEntity> request, CancellationToken cancellationToken)
        {
            var errors = new List<Error>();

            var success = await _repository.DeactivateAsync(request.Id, request.DeletedById, cancellationToken);

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
