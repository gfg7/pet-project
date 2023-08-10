using System.ComponentModel.DataAnnotations;
using Map.Contract.Controllers;
using Map.Contract.Models;
using Map.Domain.Repository.LongTermStorage;
using Microsoft.AspNetCore.Mvc;

namespace Map.Service.Controllers
{
    public class UserRouteController : ManagementApiController
    {
        private readonly RouteRepository _repository;
        public UserRouteController(RouteRepository repository)
        {
            _repository = repository;
        }

        public override async Task<IActionResult> RoutesDelete([FromQuery(Name = "routeId"), Required] string routeId)
        {
            var task = _repository.DeleteRoute(Guid.Parse(routeId));
            await task;

            return task.Exception is null ? Ok() : NotFound();
        }

        public override async Task<IActionResult> RoutesGet([FromQuery(Name = "userId")] int? userId)
        {
            var routes = await _repository.GetAllRoutes(userId ?? 0);

            return Ok(routes);
        }

        public override async Task<IActionResult> RoutesPost([FromBody] SaveRouteRequest saveRouteRequest)
        {
            var routeId = await _repository.CreateRoute(saveRouteRequest);
            var route = await _repository.GetRoute(routeId);

            return Created(routeId.ToString(), route);
        }
    }
}