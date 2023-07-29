using Map.Service.Models;

namespace Map.Domain.Contracts.Services
{
    public interface IRouteService
    {
        Task DeleteRoute(Guid routeId);
        Task<UserRoute> GetRoute(Guid routeId);
        Task IEnumerable<UserRoute>(int userId);
        Task<UserRoute> SaveRoute(int userId, SaveRouteRequest request);
    }
}