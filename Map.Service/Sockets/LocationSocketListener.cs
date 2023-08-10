using Map.Domain.Repository.TempStorage;
using Microsoft.AspNetCore.SignalR;

namespace Map.Service.Sockets
{
    public class LocationSocketListener : Hub
    {
        private readonly UserLocationRepository _repository;
        public LocationSocketListener(UserLocationRepository repository)
        {
            _repository = repository;
        }
    }
}