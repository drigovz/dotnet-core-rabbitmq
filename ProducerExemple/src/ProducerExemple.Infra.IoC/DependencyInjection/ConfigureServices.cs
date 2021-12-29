using MassTransit;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProducerExemple.Infra.IoC.DependencyInjection
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var handlers = AppDomain.CurrentDomain.Load("ProducerExemple.Application");
            services.AddMediatR(handlers);

            services.AddMassTransit(bus =>
            {
                bus.UsingRabbitMq((ctx, bussConfigurator) =>
                {
                    bussConfigurator.Host(configuration.GetConnectionString("RabbitMq"));
                });
            });

            services.AddMassTransitHostedService();

            return services;
        }
    }
}
