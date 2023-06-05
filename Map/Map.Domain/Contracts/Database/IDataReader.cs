namespace Map.Domain.Contracts.Database
{
    public interface IDataReader<K,T>
    {
        Task<T?> GetByKey(K key);
        Task<IEnumerable<T>> GetAll();
    }
}