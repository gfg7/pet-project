using System.Data;
using Map.Domain.Contracts.Database.Connection;

namespace Map.Domain.Database
{
    public class ConnectionFactoryProvider<T>  : IConnectionFactoryProvider<T> where T : IDbConnection
    {
        private readonly IConnectionProvider<T> _connectionFactory;
        public ConnectionFactoryProvider(IConnectionProvider<T> connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IConnectionProvider<T> GetProvider() => _connectionFactory;
    }
}