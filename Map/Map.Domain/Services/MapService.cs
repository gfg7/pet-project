using Map.Domain.Contracts.Services;
using Map.Service.Models;

namespace Map.Domain.Services
{
    public class MapService : IMapService, IRadarService
    {
        public Task<IEnumerable<UserLocation>> GetUsersNearby(int radius)
        {
            throw new NotImplementedException();
        }

        public Task SaveLocation(UserLocation location)
        {
            throw new NotImplementedException();
        }

        public Task<UserLocation> SetShowState(bool state)
        {
            throw new NotImplementedException();
        }
    }
}