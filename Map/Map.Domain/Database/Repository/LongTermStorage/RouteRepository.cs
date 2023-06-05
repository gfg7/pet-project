using System.Data;
using Map.Domain.Contracts.Database;
using Map.Service.Models;

namespace Map.Domain.Database.Repository.LongTermStorage
{
    public class RouteRepository : IDataReader<int, IEnumerable<Location>>, IDataManipulation<int, IEnumerable<Location>>
    {
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