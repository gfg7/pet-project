using Map.Service.Models;

namespace Map.Domain.Contracts.Services
{
    public interface INoteService
    {
        Task RemoveNote(Guid noteId);
        Task<IEnumerable<MapNote>> GetNotes(int radius);
        Task<MapNote> SaveNote(NewMapNote note);
        Task<MapNote> EditNote(NewMapNote note);
    }
}