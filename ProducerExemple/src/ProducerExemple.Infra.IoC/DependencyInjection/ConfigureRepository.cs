using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProducerExemple.Domain.Entities;
using ProducerExemple.Domain.Interfaces;
using ProducerExemple.Domain.Interfaces.Repository;
using ProducerExemple.Infra.Data.Context;
using ProducerExemple.Infra.Data.Repository;
using ProducerExemple.Infra.Data.Repository.Books;

namespace ProducerExemple.Infra.IoC.DependencyInjection
{
    public static class ConfigureRepository
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                builder => builder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName))
            );

            services.AddScoped(typeof(IBaseRepository<BaseEntity, int>), typeof(BaseRepository<BaseEntity, int>));
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
}
