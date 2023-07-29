using ClickHouse.Client.ADO;
using Map.Contract.Models;
using Map.Domain.Contracts.Database;
using Map.Domain.Contracts.Services;

namespace Map.Domain.Repository.TempStorage
{
    public class UserLocationRepository : IRadarService
    {
        private readonly IDbService<ClickHouseConnection> _executeService;

        public UserLocationRepository(IDbService<ClickHouseConnection> executeService)
        {
            _executeService = executeService;
        }

        public async Task<UserLocation> UpdateLocationPoint(LocationRequest value)
        {
            return await _executeService.Execute<UserLocation>("");
        }

        public async Task<UserLocation?> GetByKey(int userId)
        {
            var result = await _executeService.Query<UserLocation>("");
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<UserLocation>> GetUsersNearby(int radius)
        {
            return await _executeService.Query<UserLocation>("");
        }
    }
}