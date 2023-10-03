using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Cross
{
    public static class Mapping
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<GerenteService>();

            return services;
        }
    }
}
