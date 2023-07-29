using System.Data;
using Map.Domain.Database.ExcutionService;
using Map.Service.Models;

namespace Map.Domain.Repository.LongTermStorage
{
    public class MapNoteRepository
    {
        private readonly TransactionDbService<IDbConnection> _executeService;

        public MapNoteRepository(TransactionDbService<IDbConnection> executeService)
        {
            _executeService = executeService;
        }

        public async Task<MapNote> CreateNote(MapNoteRequest value)
        {
            return await _executeService.Execute<MapNote>("");
        }

        public Task<IEnumerable<MapNote>> GetAll(int radius)
        {
            return _executeService.Query<MapNote>("");
        }

        public async Task<MapNote?> GetNote(Guid key)
        {
            var result = await _executeService.Query<MapNote>("");
            return result.FirstOrDefault();
        }

        public async Task RemoveNote(Guid key)
        {
            await _executeService.Execute<int>("");
        }

        public async Task<MapNote> Update(Guid key, MapNoteRequest value)
        {
            await _executeService.Execute<Guid>("");
            return await GetNote(key);
        }
    }
}