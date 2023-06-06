using Map.Domain.Contracts.Database;
using Map.Domain.Contracts.Repository;
using Map.Service.Models;
using Npgsql;

namespace Map.Domain.Repository.LongTermStorage
{
    public class RouteRepository : IDataReader<int, IEnumerable<Location>>, IDataManipulation<int, IEnumerable<Location>>
    {
        private readonly IDbService<NpgsqlConnection> _executeService;

        public RouteRepository(IDbService<NpgsqlConnection> executeService)
        {
            _executeService = executeService;
        }

        public Task<int> Add(IEnumerable<Location> value)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IEnumerable<Location>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>?> GetByKey(int key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> Remove(int key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> Update(int key, IEnumerable<Location> value)
        {
            throw new NotImplementedException();
        }
    }
}