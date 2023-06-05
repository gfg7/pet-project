using System.Data;

namespace Map.Domain.Contracts.Database
{
    public interface IStorageConnection
    {
        bool IsTransactional();
        IDbConnection GetConnection();
    }
}