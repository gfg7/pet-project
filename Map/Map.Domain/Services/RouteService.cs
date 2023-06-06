using Map.Domain.Contracts.Services;
using Map.Domain.Repository.LongTermStorage;
using Map.Domain.Repository.TempStorage;

namespace Map.Domain.Services
{
    public class RouteService : IRouteService
    {
        private readonly RouteRepository _routeRepository;
        private readonly UserLocationRepository _userLocationRepository;

        public RouteService(RouteRepository routeRepository, UserLocationRepository userLocationRepository)
        {
            _routeRepository = routeRepository;
            _userLocationRepository = userLocationRepository;
        }

        public async Task SaveRoute(int userId, string title = null)
        {
            var points = await _userLocationRepository.GetAll();
            await _routeRepository.Add(null);
        }

        public async Task DeleteRoute(int routeId)
        {
            await _routeRepository.Remove(routeId);
        }

        public async Task GetRoutes(int userId)
        {
            await _routeRepository.GetAll();
        }

        public async Task GetRoute(int routeId)
        {
            await _routeRepository.GetByKey(routeId);
        }
    }
}