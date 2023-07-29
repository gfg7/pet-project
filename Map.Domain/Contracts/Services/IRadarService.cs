
using Map.Contract.Models;

namespace Map.Domain.Contracts.Services
{
    public interface IRadarService
    {
        Task<IEnumerable<UserLocation>> GetUsersNearby(int radius);
    }
}