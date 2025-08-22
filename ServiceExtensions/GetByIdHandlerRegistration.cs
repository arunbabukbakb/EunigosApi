using EunigosApi.Common;
using EunigosApi.Handlers;
using EunigosApi.Models.Dto;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.JobCardManagement;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Queries;
using MediatR;

namespace EunigosApi.ServiceExtensions
{
    public static class GetByIdHandlerRegistration
    {
        public static IServiceCollection AddGetByIdHandlers(this IServiceCollection services)
        {
            RegisterGetById<Estimate, EstimateDto>(services);
            RegisterGetById<Ticket, TicketDto>(services);
            RegisterGetById<JobCard, JobCardDto>(services);
            // add more entities here...

            return services;
        }

        private static void RegisterGetById<TEntity, TDto>(IServiceCollection services)
            where TEntity : class
            where TDto : class
        {
            services.AddScoped<
                IRequestHandler<BaseIdQuery<TEntity, TDto>, ApiResponse3>,
                GetByIdHandler<TEntity, TDto>>();
        }
    }

}
