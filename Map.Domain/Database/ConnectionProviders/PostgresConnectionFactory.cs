using System.Data;
using Map.Domain.Contracts.Database.Connection;
using Npgsql;

namespace Map.Domain.Database.ConnectionProviders
{
    public class PostgresConnectionProvider : IConnectionProvider<NpgsqlConnection>
    {
        public IDbConnection GetConnection()
        {
            return new NpgsqlConnection(Environment.GetEnvironmentVariable("postgres"));
        }
    }
}