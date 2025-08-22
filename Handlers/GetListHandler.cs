using AutoMapper;
using MediatR;
using EunigosApi.Common;
using EunigosApi.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EunigosApi.Queries;
using EunigosApi.Repositories.IRepository;

namespace EunigosApi.Handlers
{
    public class GetListHandler<TEntity, TDto>
     : IRequestHandler<BaseListQuery<TEntity, TDto>, ApiResponse3>
         where TEntity : class
         where TDto : class
    {
        private readonly IMapper _mapper;
        private readonly IRepository<TEntity> _repository;

        public GetListHandler(IMapper mapper, IRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ApiResponse3> Handle(BaseListQuery<TEntity, TDto> request, CancellationToken cancellationToken)
        {
            var errorList = new List<Error>();
            var dtoList = new List<TDto>();
            var metaData = new MetaData();
            var repoQuery = _mapper.Map<BaseListRepoQuery>(request);

            try
            {
                var data = await _repository.GetListAsync(repoQuery, cancellationToken);

                if (data.Items.Any())
                {
                    var pagination = UtilityHelper.GetPagination<TEntity>(data);
                    metaData = new MetaData { Pagination = pagination };
                    dtoList = _mapper.Map<List<TDto>>(data.Items);

                    return new ApiResponse3(true, errorList, dtoList, metaData, pagination);
                }
                else
                {
                    return new ApiResponse3(true, errorList, dtoList, metaData, null);
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

            return new ApiResponse3(false, errorList, null, metaData, null);
        }
    }
}
