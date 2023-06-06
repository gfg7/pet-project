using System.Data;

namespace Map.Domain.Contracts.Database.Connection
{
    public interface IConnectionFactoryProvider<T> where T : IDbConnection
    {
        IConnectionProvider<T> GetProvider();
    }
}