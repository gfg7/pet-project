using System.Data;

namespace Map.Domain.Contracts.Database.Connection
{
    public interface IConnectionProvider<T> where T : IDbConnection
    {
        IDbConnection GetConnection();
    }
}