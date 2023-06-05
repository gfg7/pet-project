using System.Data;
using ClickHouse.Client.ADO;
using Dapper;
using Map.Domain.Contracts.Database;
using Map.Service.Models;

namespace Map.Domain.Database.Repository.TempStorage
{
    public class UserLocationRepository : IKeyValueStore<string,UserLocation>, IDataReader<string,UserLocation>
    {
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