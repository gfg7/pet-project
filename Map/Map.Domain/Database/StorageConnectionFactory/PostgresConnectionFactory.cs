using System.Data;
using Map.Domain.Contracts.Database;
using Npgsql;

namespace Map.Domain.Database.StorageConnectionFactory
{
    public class PostgresConnectionFactory : IStorageConnection
    {
        public IDbConnection GetConnection()
        {
            return new NpgsqlConnection(Environment.GetEnvironmentVariable("postgres"));
        }

        public bool IsTransactional() => true;
    }
}