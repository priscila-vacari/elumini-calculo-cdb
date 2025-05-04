using CalculoCDB.Application.Interfaces;
using CalculoCDB.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace CalculoCDB.Application
{
    [ExcludeFromCodeCoverage]
    public static class ApplicationDependencyRegister
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddDependencyServices();
        }

        private static IServiceCollection AddDependencyServices(this IServiceCollection services)
        {
            services.AddTransient<ICdbService, CdbService>();

            return services;
        }
    }
}
