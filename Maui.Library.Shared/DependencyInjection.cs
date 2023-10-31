using Microsoft.Extensions.Configuration;

namespace Maui.Library.Shared;

public static class DependencyInjection
{
    public static IServiceCollection AddSharedApp(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<HttpClient>(opt =>
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(configuration["YoutubeAPI"])
            };

            return httpClient;
        });
        return services;
    }
}
