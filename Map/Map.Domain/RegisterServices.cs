using Microsoft.Extensions.DependencyInjection;

namespace Map.Domain
{
    public static class RegisterServices
    {
        public static IServiceCollection RegisterDomain(this IServiceCollection services) {
            services.AddLogging();
            services.AddHttpClient();
            services.AddSignalR();

            return services;
        }
    }
}