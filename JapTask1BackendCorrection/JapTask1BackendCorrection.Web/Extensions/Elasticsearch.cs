using JapTask1BackendCorrection.Core.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using System;

namespace JapTask1BackendCorrection.Web.Extensions
{
    public static class Elasticsearch
    {
        public static void AddElasticsearch(
        this IServiceCollection services, IConfiguration configuration)
        {
            var url = configuration["elasticsearch:url"];
            var defaultIndex = configuration["elasticsearch:index"];

            var settings = new ConnectionSettings(new Uri(url))
                .DefaultIndex(defaultIndex)
                .DefaultMappingFor<Rating>(m => m
                    .Ignore(r => r.ArchivedAt)
                    .Ignore(r => r.ArchivedBy)
                    .Ignore(r => r.CreatedAt)
                    .Ignore(r => r.CreatedBy)
                    .PropertyName(r => r.Id, "id")
                );

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);
        }
    }
}
