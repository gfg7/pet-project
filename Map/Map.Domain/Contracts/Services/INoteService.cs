using Map.Service.Models;

namespace Map.Domain.Contracts.Services
{
    public interface INoteService
    {
        Task RemoveNote(int noteId);
        Task<IEnumerable<MapNote>> GetNotes(int radius);
        Task<MapNote> SaveNote(MapNote note);
        Task<MapNote> EditNote(MapNote note);
    }
}