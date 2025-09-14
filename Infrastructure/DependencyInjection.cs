using Domain.Repositories;
using FluentValidation;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultDb") ?? throw new InvalidOperationException("Connection string 'DefaultDb' not found.");
            services.AddDbContext<CoreDbContext>(
                options => options.UseSqlServer(connectionString, sqlOptions => sqlOptions.MigrationsHistoryTable("__CoreMigrationsHistory"))
            );
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ISalaryRepository, SalaryRepository>();

            return services;
        }

    }
}
