using EunigosApi.Common;
using EunigosApi.Handlers;
using EunigosApi.Models.Dto;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Queries;
using MediatR;

namespace EunigosApi.ServiceExtensions
{
    public static class ListHandlerRegistration
    {
        public static IServiceCollection AddListHandlers(this IServiceCollection services)
        {
            RegisterList<Estimate, EstimateDto>(services);
            RegisterList<Ticket, TicketDto>(services);
            // add more entities here...

            return services;
        }

        private static void RegisterList<TEntity, TDto>(IServiceCollection services)
            where TEntity : class
            where TDto : class
        {
            services.AddScoped<
                IRequestHandler<BaseListQuery<TEntity, TDto>, ApiResponse3>,
                GetListHandler<TEntity, TDto>>();
        }
    }

}
