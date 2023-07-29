using System.Data;
using Map.Domain.Database.ExcutionService;
using Map.Service.Models;

namespace Map.Domain.Repository.LongTermStorage
{
    public class RouteRepository 
    {
        private readonly TransactionDbService<IDbConnection> _executeService;

        public RouteRepository(TransactionDbService<IDbConnection> executeService)
        {
            _executeService = executeService;
        }

        public async Task<Guid> CreateRoute(SaveRouteRequest value)
        {
            var points = await _executeService.Query<Location>("");
            return await _executeService.Execute<Guid>("");
        }

        public Task<IEnumerable<UserRoute>> GetAllRoutes(int userId)
        {
            return _executeService.Query<UserRoute>("");
        }

        public async Task<UserRoute?> GetRoute(Guid key)
        {
            var result = await _executeService.Query<UserRoute>("");
            return result.FirstOrDefault();
        }

        public async Task<UserRoute> DeleteRoute(Guid key)
        {
            var route = await GetRoute(key);

            if (route is null)
            {
                throw new Exception();
            }

            await _executeService.Execute<int>("");
            return route;
        }
    }
}