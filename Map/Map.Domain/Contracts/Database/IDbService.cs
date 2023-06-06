using System.Data;
namespace Map.Domain.Contracts.Database
{
    public interface IDbService<T> where T : IDbConnection
    {
        void Dispose();
        Task Execute(string query);
        Task<IEnumerable<E>> Query<E>(string query) where E : class;
    }
}