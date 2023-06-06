namespace Map.Domain.Contracts.Repository
{
    public interface IKeyValueStore<K,T> {
        Task<K> Add(T value);
        Task<T> Remove(K key);
    }
}