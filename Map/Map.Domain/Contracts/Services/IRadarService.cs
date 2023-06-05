using Map.Service.Models;

namespace Map.Domain.Contracts.Services
{
    public interface IRadarService
    {
        Task<IEnumerable<UserLocation>> GetUsersNearby(int radius);
    }
}