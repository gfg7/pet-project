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
using Map.Service.Attributes;
using Map.Service.Models;

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
        [SwaggerResponse(statusCode: 200, type: typeof(List<UserRoute>), description: "Маршрут удален")]
        public virtual Task<IActionResult> RoutesDelete([FromQuery (Name = "routeId")][Required()]string routeId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<UserRoute>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"routeId\" : \"routeId\",\r\n  \"userId\" : 0,\r\n  \"routeName\" : \"routeName\",\r\n  \"points\" : [ {\r\n    \"pointId\" : \"pointId\"\r\n  }, {\r\n    \"pointId\" : \"pointId\"\r\n  } ]\r\n}, {\r\n  \"routeId\" : \"routeId\",\r\n  \"userId\" : 0,\r\n  \"routeName\" : \"routeName\",\r\n  \"points\" : [ {\r\n    \"pointId\" : \"pointId\"\r\n  }, {\r\n    \"pointId\" : \"pointId\"\r\n  } ]\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<UserRoute>>(exampleJson)
            : default(List<UserRoute>);
            //TODO: Change the data returned
            return Task.FromResult<IActionResult>(new ObjectResult(example));
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
        [SwaggerResponse(statusCode: 200, type: typeof(List<UserRoute>), description: "Массив координат сохраненных маршрутов пользователя")]
        public virtual Task<IActionResult> RoutesGet([FromQuery (Name = "userId")]int? userId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<UserRoute>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"routeId\" : \"routeId\",\r\n  \"userId\" : 0,\r\n  \"routeName\" : \"routeName\",\r\n  \"points\" : [ {\r\n    \"pointId\" : \"pointId\"\r\n  }, {\r\n    \"pointId\" : \"pointId\"\r\n  } ]\r\n}, {\r\n  \"routeId\" : \"routeId\",\r\n  \"userId\" : 0,\r\n  \"routeName\" : \"routeName\",\r\n  \"points\" : [ {\r\n    \"pointId\" : \"pointId\"\r\n  }, {\r\n    \"pointId\" : \"pointId\"\r\n  } ]\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<UserRoute>>(exampleJson)
            : default(List<UserRoute>);
            //TODO: Change the data returned
            return Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Feature Сохранение маршрута
        /// </summary>
        /// <param name="routesDeleteRequest">Параметры маршрута</param>
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
        public virtual Task<IActionResult> RoutesPost([FromBody]RoutesDeleteRequest routesDeleteRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UserRoute));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorMessage));
            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(ErrorMessage));
            string exampleJson = null;
            exampleJson = "{\r\n  \"routeId\" : \"routeId\",\r\n  \"userId\" : 0,\r\n  \"routeName\" : \"routeName\",\r\n  \"points\" : [ {\r\n    \"pointId\" : \"pointId\"\r\n  }, {\r\n    \"pointId\" : \"pointId\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserRoute>(exampleJson)
            : default(UserRoute);
            //TODO: Change the data returned
            return Task.FromResult<IActionResult>(new ObjectResult(example));
        }
    }
}
