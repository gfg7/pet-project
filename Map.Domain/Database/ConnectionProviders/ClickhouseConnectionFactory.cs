using System.Data;
using ClickHouse.Client.ADO;
using Map.Domain.Contracts.Database.Connection;

namespace Map.Domain.Database.ConnectionProviders
{
    public class ClickhouseConnectionProvider : IConnectionProvider<ClickHouseConnection>
    {
        private readonly IHttpClientFactory _httpClient;
        public ClickhouseConnectionProvider(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public IDbConnection GetConnection()
        {
            return new ClickHouseConnection(Environment.GetEnvironmentVariable("clickhouse"), _httpClient);
        }
    }
}