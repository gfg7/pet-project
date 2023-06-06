namespace Map.Domain.Contracts.Repository
{
    public interface IDataManipulation<K,T> : IKeyValueStore<K,T>
    {
        Task<T> Update(K key, T value);
    }
}