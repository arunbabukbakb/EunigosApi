using EunigosApi.Common;
using EunigosApi.Models;
using EunigosApi.Queries;
using AutoMapper;
using MediatR;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Handlers
{
    public class GetByIdHandler<TEntity, TDto>
        : IRequestHandler<BaseIdQuery<TEntity, TDto>, ApiResponse3>
        where TEntity : class
        where TDto : class
    {
        private readonly IMapper _mapper;
        private readonly IRepository<TEntity> _repository;

        public GetByIdHandler(IMapper mapper, IRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ApiResponse3> Handle(BaseIdQuery<TEntity, TDto> request, CancellationToken cancellationToken)
        {
            var errorList = new List<Error>();
            TDto? dto = null;

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id, request.Includes, cancellationToken);

                if (entity != null)
                {
                    dto = _mapper.Map<TDto>(entity);
                    return new ApiResponse3(true, errorList, dto, null, null);
                }
                else
                {
                    errorList.Add(new Error
                    {
                        Code = AppCodes.NotFoundActivity,
                        Message = "Record not found",
                        Field = "Id"
                    });

                    return new ApiResponse3(false, errorList, null, null, null);
                }
            }
            catch (Exception ex)
            {
                errorList.Add(new Error
                {
                    Code = AppCodes.FailureInternalException,
                    Message = ex.Message,
                    Field = "Exception"
                });
            }

            return new ApiResponse3(false, errorList, null, null, null);
        }
    }
}
