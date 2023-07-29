using Map.Domain.Contracts.Services;
using Map.Service.Models;

namespace Map.Test.MapService;

public class SaveLocationTest
{
    private readonly IMapService _service;
    public SaveLocationTest(IMapService service)
    {
        _service = service;
    }

    [Fact]
    public async Task HappyPath()
    {
        var location = new Location() {
                Longtitude = 13.4M,
                Latitude = 221M,
                Speed = 3,
                Course = 45M
            };

        await _service.SaveLocation(location);
    }

    [Fact]
    public async Task Invalid_Coordinates()
    {
        var location = new Location() {
                Longtitude = 13.4M,
                Latitude = 221M,
                Speed = 3,
                Course = 45M
            };

        await _service.SaveLocation(location);
    }
}