using EunigosApi.Commands;
using EunigosApi.Common;
using EunigosApi.Handlers;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.TicketManagement;
using MediatR;

namespace EunigosApi.ServiceExtensions
{
    public static class DeactivateHandlerRegistration
    {
        public static IServiceCollection AddDeactivateHandlers(this IServiceCollection services)
        {
            RegisterDeactivate<Estimate>(services);
            RegisterDeactivate<Ticket>(services);
            // add more entities here...

            return services;
        }

        private static void RegisterDeactivate<TEntity>(IServiceCollection services)
            where TEntity : class
        {
            services.AddScoped<
                IRequestHandler<BaseDeactivateCommand<TEntity>, ApiResponse3>,
                DeactivateHandler<TEntity>>();
        }
    }

}
