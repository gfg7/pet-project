using System.Data;
using Dapper;
using Map.Domain.Contracts.Database;

namespace Map.Domain.Database
{
    public class ExecuteService : IDisposable, IExecuteService
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction? _transaction;

        public ExecuteService(IStorageConnection connection)
        {
            _connection = connection.GetConnection();

            if (connection.IsTransactional())
            {
                _transaction = _connection.BeginTransaction();
            }
        }

        public async Task Execute(string query)
        {
            try
            {
                await RunExecute(query);
                _transaction?.Commit();
            }
            catch (System.Exception)
            {
                _transaction?.Rollback();
                throw;
            }
        }

        private async Task RunExecute(string query)
        {
            await _connection.ExecuteAsync(query);
        }

        public async Task<IEnumerable<T>> Query<T>(string query) => await _connection.QueryAsync<T>(query);

        public void Dispose()
        {
            _transaction?.Dispose();
            _connection.Close();
            _connection.Dispose();
        }
    }
}