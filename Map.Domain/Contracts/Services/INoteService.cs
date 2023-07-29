
using Map.Contract.Models;

namespace Map.Domain.Contracts.Services
{
    public interface INoteService
    {
        Task RemoveNote(Guid noteId);
        Task<IEnumerable<MapNote>> GetNotes(int radius);
        Task<MapNote> SaveNote(MapNoteRequest note);
        Task<MapNote> EditNote(MapNoteRequest note);
    }
}