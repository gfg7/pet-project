using Map.Domain.Contracts.Database;
using Map.Domain.Contracts.Repository;
using Map.Service.Models;
using Npgsql;

namespace Map.Domain.Repository.LongTermStorage
{
    public class MapNoteRepository : IDataReader<int, MapNote>, IDataManipulation<int, MapNote>
    {
        private readonly IDbService<NpgsqlConnection> _executeService;

        public MapNoteRepository(IDbService<NpgsqlConnection> executeService)
        {
            _executeService = executeService;
        }

        public Task<int> Add(MapNote value)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MapNote>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<MapNote?> GetByKey(int key)
        {
            throw new NotImplementedException();
        }

        public Task<MapNote> Remove(int key)
        {
            throw new NotImplementedException();
        }

        public Task<MapNote> Update(int key, MapNote value)
        {
            throw new NotImplementedException();
        }
    }
}