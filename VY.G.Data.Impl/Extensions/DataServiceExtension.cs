using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VY.G.Data.Impl.Context;

namespace VY.G.Data.Impl.Extensions
{
    public static class DataServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<PersonsDbContext>(context =>
            {
                context.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
                context.UseInMemoryDatabase("PersonsDB");
            });

            return services;
        }
    }
}
