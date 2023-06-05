using System.Data;
using ClickHouse.Client.ADO;
using Map.Domain.Contracts.Database;

namespace Map.Domain.Database.StorageConnectionFactory
{
    public class ClickhouseConnectionFactory : IStorageConnection
    {
        private readonly IHttpClientFactory _httpClient;
        public ClickhouseConnectionFactory(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public IDbConnection GetConnection()
        {
            return new ClickHouseConnection(Environment.GetEnvironmentVariable("clickhouse"), _httpClient);
        }

        public bool IsTransactional() => false;
    }
}