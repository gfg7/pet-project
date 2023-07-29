/*
 * API MVP Карты
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Map.Contract.Attributes;
using Map.Contract.Models;

namespace Map.Contract.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class ManagementApiController : ControllerBase
    { 
        /// <summary>
        /// Feature Удаление маршрута
        /// </summary>
        /// <param name="routeId"></param>
        /// <response code="200">Маршрут удален</response>
        /// <response code="404">Маршрут не существует</response>
        [HttpDelete]
        [Route("/routes")]
        [ValidateModelState]
        [SwaggerOperation("RoutesDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<UserRoute>), description: "Маршрут удален")]
        public abstract Task<IActionResult> RoutesDelete([FromQuery (Name = "routeId")][Required()]string routeId);

        /// <summary>
        /// Modal История маршрутов
        /// </summary>
        /// <remarks>Получение массива координат сохраненных маршрутов пользователя</remarks>
        /// <param name="userId"></param>
        /// <response code="200">Массив координат сохраненных маршрутов пользователя</response>
        /// <response code="404">Пользователя не существует</response>
        [HttpGet]
        [Route("/routes")]
        [ValidateModelState]
        [SwaggerOperation("RoutesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<UserRoute>), description: "Массив координат сохраненных маршрутов пользователя")]
        public abstract Task<IActionResult> RoutesGet([FromQuery (Name = "userId")]int? userId);

        /// <summary>
        /// Feature Сохранение маршрута
        /// </summary>
        /// <param name="saveRouteRequest">Параметры маршрута</param>
        /// <response code="200">Массив координат сохраненного маршрута</response>
        /// <response code="400">Ошибка валидации тела запроса</response>
        /// <response code="409">Ошибка сохранения маршрута</response>
        [HttpPost]
        [Route("/routes")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("RoutesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserRoute), description: "Массив координат сохраненного маршрута")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorMessage), description: "Ошибка валидации тела запроса")]
        [SwaggerResponse(statusCode: 409, type: typeof(ErrorMessage), description: "Ошибка сохранения маршрута")]
        public abstract Task<IActionResult> RoutesPost([FromBody]SaveRouteRequest saveRouteRequest);
    }
}
