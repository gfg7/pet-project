using Map.Service.Models;

namespace Map.Domain.Contracts.Services
{
    public interface IMapService
    {
        Task<Location> SaveLocation(LocationRequest location);
        Task<UserLocation> SetShowState(bool state);
    }
}