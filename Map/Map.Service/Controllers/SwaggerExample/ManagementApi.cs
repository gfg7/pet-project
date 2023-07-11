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
using Map.Service.Attributes;
using Map.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Map.Service.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ManagementApiController : ControllerBase
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
        public virtual Task<IActionResult> RoutesDelete([FromQuery(Name = "routeId")][Required()] int routeId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            return Task.FromResult<IActionResult>(Ok());
        }

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
        [SwaggerResponse(statusCode: 200, type: typeof(List<Location>), description: "Массив координат сохраненных маршрутов пользователя")]
        public virtual Task<IActionResult> RoutesGet([FromQuery(Name = "userId")] int? userId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Location>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"routeId\" : 1,\r\n  \"latitude\" : 5.637376656633329,\r\n  \"longtitude\" : 5.962133916683182,\r\n  \"course\" : 2.3021358869347655,\r\n  \"speed\" : 7.061401241503109\r\n}, {\r\n  \"routeId\" : 1,\r\n  \"latitude\" : 5.637376656633329,\r\n  \"longtitude\" : 5.962133916683182,\r\n  \"course\" : 2.3021358869347655,\r\n  \"speed\" : 7.061401241503109\r\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Location>>(exampleJson)
            : default(List<Location>);
            //TODO: Change the data returned
            return Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Feature Сохранение маршрута
        /// </summary>
        /// <response code="200">массив координат сохраненного маршрута</response>
        /// <response code="400">Ошибка валидации тела запроса</response>
        /// <response code="409">Ошибка сохранения маршрута</response>
        [HttpPost]
        [Route("/routes")]
        [ValidateModelState]
        [SwaggerOperation("RoutesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Location>), description: "массив координат сохраненного маршрута")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorMessage), description: "Ошибка валидации тела запроса")]
        [SwaggerResponse(statusCode: 409, type: typeof(ErrorMessage), description: "Ошибка сохранения маршрута")]
        public virtual Task<IActionResult> RoutesPost()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Location>));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorMessage));
            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(ErrorMessage));
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"routeId\" : 1,\r\n  \"latitude\" : 5.637376656633329,\r\n  \"longtitude\" : 5.962133916683182,\r\n  \"course\" : 2.3021358869347655,\r\n  \"speed\" : 7.061401241503109\r\n}, {\r\n  \"routeId\" : 1,\r\n  \"latitude\" : 5.637376656633329,\r\n  \"longtitude\" : 5.962133916683182,\r\n  \"course\" : 2.3021358869347655,\r\n  \"speed\" : 7.061401241503109\r\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Location>>(exampleJson)
            : default(List<Location>);
            //TODO: Change the data returned
            return Task.FromResult<IActionResult>(new ObjectResult(example));
        }
    }
}