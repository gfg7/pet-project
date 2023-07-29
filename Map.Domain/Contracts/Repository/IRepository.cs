namespace Map.Domain.Contracts.Repository
{
    public interface IRepository<K,T> : IDataReader<K,T>, IDataManipulation<K,T>
    {
        
    }
}