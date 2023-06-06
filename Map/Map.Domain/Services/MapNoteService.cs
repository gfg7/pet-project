using Map.Domain.Contracts.Services;
using Map.Service.Models;

namespace Map.Domain.Services
{
    public class MapNoteService : INoteService
    {
        public Task<MapNote> EditNote(MapNote note)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MapNote>> GetNotes(int radius)
        {
            throw new NotImplementedException();
        }

        public Task RemoveNote(int noteId)
        {
            throw new NotImplementedException();
        }

        public Task<MapNote> SaveNote(MapNote note)
        {
            throw new NotImplementedException();
        }
    }
}