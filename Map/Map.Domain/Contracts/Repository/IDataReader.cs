namespace Map.Domain.Contracts.Repository
{
    public interface IDataReader<K,T>
    {
        Task<T?> GetByKey(K key);
        Task<IEnumerable<T>> GetAll();
    }
}