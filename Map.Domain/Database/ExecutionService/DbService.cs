using System.Data;
using Dapper;
using Map.Domain.Contracts.Database;
using Map.Domain.Contracts.Database.Connection;

namespace Map.Domain.Database.ExcutionService
{
    public class DbService<T> : IDisposable, IDbService<T> where T : IDbConnection
    {
        protected readonly IDbConnection _connection;

        public DbService(IConnectionFactoryProvider<T> factory)
        {
            _connection = factory.GetProvider().GetConnection();
        }

        public virtual async Task<K> Execute<K>(string query) where K : new() => await _connection.ExecuteScalarAsync<K>(query);


        public virtual void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }

        public virtual async Task<IEnumerable<E>> Query<E>(string query) where E : new() => await _connection.QueryAsync<E>(query);
    }
}