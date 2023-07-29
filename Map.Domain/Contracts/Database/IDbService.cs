using System.Data;
namespace Map.Domain.Contracts.Database
{
    public interface IDbService<T> where T : IDbConnection
    {
        void Dispose();
        Task<K> Execute<K>(string query)  where K : new();
        Task<IEnumerable<E>> Query<E>(string query) where E : new();
    }
}