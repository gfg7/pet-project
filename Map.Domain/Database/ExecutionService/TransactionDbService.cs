using System.Data;
using System.Linq.Expressions;
using Map.Domain.Contracts.Database.Connection;

namespace Map.Domain.Database.ExcutionService
{
    public class TransactionDbService<T> : DbService<T> where T : IDbConnection
    {
        private IDbTransaction _transaction;

        public TransactionDbService(IConnectionFactoryProvider<T> factory) : base(factory) { }

        public override Task<E> Execute<E>(string query)
        {
            return Task.FromResult(TransactionProcess<E>(x=> base.Execute<E>(query), query));
        }

        private E TransactionProcess<E>(Func<string, object> process, string query)
        {
            try
            {
                _transaction = _connection.BeginTransaction();

                var result = process.Invoke(query);

                _transaction.Commit();

                return (E)result;
            }
            catch (System.Exception ex)
            {
                _transaction.Rollback();
                throw ex;
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public override Task<IEnumerable<E>> Query<E>(string query)
        {
            return Task.FromResult(TransactionProcess<IEnumerable<E>>(x=> base.Query<E>(query), query));
        }
    }
}