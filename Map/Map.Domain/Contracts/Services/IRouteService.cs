namespace Map.Domain.Contracts.Services
{
    public interface IRouteService
    {
        Task DeleteRoute(int routeId);
        Task GetRoute(int routeId);
        Task GetRoutes(int userId);
        Task SaveRoute(int userId, string title = null);
    }
}