using EunigosApi.Commands;
using EunigosApi.Common;
using EunigosApi.Handlers;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.TicketManagement;
using MediatR;

namespace EunigosApi.ServiceExtensions
{
    public static class DeleteHandlerRegistration
    {
        public static IServiceCollection AddDeleteHandlers(this IServiceCollection services)
        {
            //RegisterDelete<Estimate>(services);
            //RegisterDelete<Ticket>(services);
            // add more entities here...

            return services;
        }

        private static void RegisterDelete<TEntity>(IServiceCollection services)
            where TEntity : class
        {
            services.AddScoped<
                IRequestHandler<BaseDeleteCommand<TEntity>, ApiResponse3>,
                BaseDeleteHandler<TEntity>>();
        }
    }

}
