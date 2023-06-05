namespace Map.Domain.Contracts.Database
{
    public interface IDataManipulation<K,T> : IKeyValueStore<K,T>
    {
        Task<T> Update(K key, T value);
    }

    public interface IKeyValueStore<K,T> {
        Task<K> Add(T value);
        Task<T> Remove(K key);
    }
}