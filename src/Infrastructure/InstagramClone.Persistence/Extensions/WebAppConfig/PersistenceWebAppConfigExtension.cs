using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Utils.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InstagramClone.Persistence.Extensions.AspNetCore
{
    public static class PersistenceWebAppConfigExtension
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options
                => options.UseNpgsql(config.GetConnectionString("WriteDb")));

            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddScoped<HttpContextUtils>();

            return services;
        }
    }
}