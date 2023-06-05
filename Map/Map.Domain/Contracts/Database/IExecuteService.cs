namespace Map.Domain.Contracts.Database
{
    public interface IExecuteService
    {
        void Dispose();
        Task Execute(string query);
        Task<IEnumerable<T>> Query<T>(string query);
    }
}