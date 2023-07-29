using System.Data;
using ClickHouse.Client.ADO;
using Map.Domain.Contracts.Database;
using Map.Domain.Contracts.Database.Connection;
using Map.Domain.Database;
using Map.Domain.Database.ConnectionProviders;
using Map.Domain.Database.ExcutionService;
using Map.Domain.Repository.LongTermStorage;
using Map.Domain.Repository.TempStorage;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Map.Domain
{
    public static class RegisterServices
    {
        public static IServiceCollection RegisterDomain(this IServiceCollection services)
        {
            services.AddLogging();
            services.AddHttpClient();

            services.AddScoped(typeof(DbService<>));
            services.AddScoped(typeof(TransactionDbService<>));

            services.RegisterDatabase<ClickHouseConnection, ClickhouseConnectionProvider, DbService<ClickHouseConnection>>();
            services.RegisterDatabase<NpgsqlConnection, PostgresConnectionProvider, TransactionDbService<NpgsqlConnection>>(true);

            services.AddScoped<MapNoteRepository>();
            services.AddScoped<RouteRepository>();
            services.AddScoped<UserLocationRepository>();

            return services;
        }

        public static IServiceCollection RegisterDatabase<C, F, S>(this IServiceCollection services, bool isTransactional = false)
        where C : IDbConnection
        where F : class, IConnectionProvider<C>
        where S : IDbService<C>
        {
            services.AddScoped<IConnectionProvider<C>, F>();
            services.AddScoped<IConnectionFactoryProvider<C>, ConnectionFactoryProvider<C>>();
            services.AddScoped(typeof(IDbService<C>), typeof(S));

            if (isTransactional) {
                services.AddScoped(typeof(TransactionDbService<IDbConnection>), typeof(S));
            }

            return services;
        }
    }
}