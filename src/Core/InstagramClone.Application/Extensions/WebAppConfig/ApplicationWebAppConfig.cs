using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace InstagramClone.Application.Extensions.WebAppConfig
{
    public static class ApplicationWebAppConfig
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assembly);

            services.AddMediatR(config
                => config.RegisterServicesFromAssembly(assembly));

            return services;
        }
    }
}