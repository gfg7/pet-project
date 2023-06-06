using ClickHouse.Client.ADO;
using Map.Domain.Contracts.Database;
using Map.Domain.Contracts.Repository;
using Map.Service.Models;

namespace Map.Domain.Repository.TempStorage
{
    public class UserLocationRepository : IKeyValueStore<string, UserLocation>, IDataReader<string, UserLocation>
    {
        private readonly IDbService<ClickHouseConnection> _executeService;

        public UserLocationRepository(IDbService<ClickHouseConnection> executeService)
        {
            _executeService = executeService;
        }

        public Task<string> Add(UserLocation value)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserLocation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserLocation?> GetByKey(string key)
        {
            throw new NotImplementedException();
        }

        public Task<UserLocation> Remove(string key)
        {
            throw new NotImplementedException();
        }
    }
}