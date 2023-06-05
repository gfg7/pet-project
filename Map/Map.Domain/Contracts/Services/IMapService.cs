using Map.Service.Models;

namespace Map.Domain.Contracts.Services
{
    public interface IMapService
    {
        Task SaveLocation(UserLocation location);
        Task<UserLocation> SetShowState(bool state);
    }
}