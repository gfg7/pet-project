using System.Data;
using Map.Domain.Contracts.Database.Connection;

namespace Map.Domain.Database.ExcutionService
{
    public class TransactionDbService<T> : DbService<T> where T : IDbConnection
    {
        private IDbTransaction _transaction;

        public TransactionDbService(IConnectionFactoryProvider<T> factory) : base(factory) { }

        public override async Task Execute(string query)
        {
            try
            {
                _transaction = _connection.BeginTransaction();

                await base.Execute(query);

                _transaction.Commit();
            }
            catch (System.Exception)
            {
                _transaction.Rollback();
                throw;
            }
        }

        public override void Dispose()
        {
            _transaction.Dispose();
            base.Dispose();
        }
    }
}