using JapTask1BackendCorrection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Middleware
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public ErrorMiddleware(RequestDelegate next, ILogger<ErrorMiddleware> logger, IHostEnvironment env)
        {
            _env = env;
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                if(_env.IsDevelopment()) 
                   _logger.LogError(e, e.Message);

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;

                var response = _env.IsDevelopment() ?
                    new ErrorClass 
                    {
                        StatusCode = context.Response.StatusCode, 
                        Message = e.Message, 
                        StackTrace = e.StackTrace?.ToString()
                    } 
                    :
                    new ErrorClass
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Internal server error"
                    };

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
